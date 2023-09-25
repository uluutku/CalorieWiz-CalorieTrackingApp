using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using CalorieTrackingApp.DATA.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackingApp.UI
{
    public partial class AddFoodToSystem : Form
    {
        private ProjectContext db;
        private FoodRepository foodRepository;
        Account account;
        string imagePath = null;
        byte[] DefaultImage;
        public AddFoodToSystem()
        {
            InitializeComponent();
        }

        public AddFoodToSystem(Account _account)
        {
            InitializeComponent();
            account = _account;
        }

        private string defaultText = "Aranacak yemek giriniz";

        private void AddFoodToSystem_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = CalorieTrackingApp.UI.Properties.Resources.DefaultFood;
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                DefaultImage = stream.ToArray();
            }
            db = new ProjectContext();
            foodRepository = new FoodRepository();
            BringTheUpdatedFoodList();
            textBox1.Text = defaultText; // Varsayılan metni ayarla
            ClearFoodDetails();
        }

        private string filterText = "";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var keyword = textBox1.Text.ToLower();
            if (keyword == defaultText.ToLower())
                filterText = ""; // Varsayılan metinse filtre metnini temizle
            else
                filterText = keyword;

            var filteredFoodNames = db.Foods
                .Where(f => f.Name.ToLower().Contains(filterText))
                .Select(f => f.Name)
                .ToList();
            listBox1.DataSource = filteredFoodNames;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == defaultText)
                textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                textBox1.Text = defaultText;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) // ListBox'ta bir öğe seçili mi?
            {
                btnNewFoodSave.Text = "Guncelle";
                groupBox2.Text = "Yemegi Guncelle";
                // Seçilen yemeği al
                string selectedFoodName = listBox1.SelectedItem.ToString();
                Food selectedFood = foodRepository.GetByName(selectedFoodName);

                if (selectedFood != null)
                {
                    // Seçilen yemeğin bilgilerini yandaki kontrollere doldur
                    txtFoodName.Text = selectedFood.Name;
                    nudCalorieValue.Value = (decimal)selectedFood.PortionCalorie;
                    nudProtein.Value = (decimal)selectedFood.PortionProtein;
                    nudFat.Value = (decimal)selectedFood.PortionFat;
                    nudCarb.Value = (decimal)selectedFood.PortionCarb;

                    if (selectedFood.Photo != null)
                    {
                        using (MemoryStream ms = new MemoryStream(selectedFood.Photo))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }

                    GraphicsPath obj = new GraphicsPath();
                    obj.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
                    Region rg = new Region(obj);
                    pictureBox1.Region = rg;
                }
                isEditMode = true;
            }
        }

        private bool isEditMode = false;

        private void btnNewFoodSave_Click(object sender, EventArgs e)
        {
            if (nudCalorieValue.Value != 0 && txtFoodName.Text != "")
            {
                if (!isEditMode)
                {
                    // Yeni yemek ekleme işlemi
                    Food newFood = new Food
                    {
                        Name = txtFoodName.Text,
                        StandartPortion = 100,
                        PortionCalorie = (double)nudCalorieValue.Value,
                        PortionProtein = (double)nudProtein.Value,
                        PortionFat = (double)nudFat.Value,
                        PortionCarb = (double)nudCarb.Value,
                        Photo = imagePath != null ? File.ReadAllBytes(imagePath) : DefaultImage

                    };

                    foodRepository.Add(newFood);
                    MessageBox.Show("Yemek başarıyla kaydedildi.");
                    BringTheUpdatedFoodList();
                    groupBox2.Text = "Yeni Yemek Ekle";
                }

                else
                {
                    // Yemek Düzenleme ve Guncelleme işlemi
                    if (listBox1.SelectedIndex != -1)
                    {
                        string selectedFoodName = listBox1.SelectedItem.ToString();
                        Food selectedFood = foodRepository.GetByName(selectedFoodName);

                        if (selectedFood != null)
                        {
                            // Kullanıcı tarafından yapılan güncellemeleri al
                            string updatedName = txtFoodName.Text;
                            double updatedPortion = 100;
                            double updatedCalorie = (double)nudCalorieValue.Value;
                            double updatedProtein = (double)nudProtein.Value;
                            double updatedFat = (double)nudFat.Value;
                            double updatedCarb = (double)nudCarb.Value;

                            // Veritabanında güncelleme yap
                            selectedFood.Name = updatedName;
                            selectedFood.StandartPortion = updatedPortion;
                            selectedFood.PortionCalorie = updatedCalorie;
                            selectedFood.PortionProtein = updatedProtein;
                            selectedFood.PortionFat = updatedFat;
                            selectedFood.PortionCarb = updatedCarb;
                            selectedFood.Photo = imagePath != null ? File.ReadAllBytes(imagePath) : DefaultImage;

                            foodRepository.Update(selectedFood);
                            BringTheUpdatedFoodList();
                        }
                    }
                    MessageBox.Show("Yemek başarıyla güncellendi.");
                    groupBox2.Text = "Yeni Yemek Ekle";
                    isEditMode = false; // Düzenleme modunu devre dışı bırak
                }

                // Kontrolleri temizle
                ClearFoodDetails();
                btnNewFoodSave.Text = "Sisteme Kaydet"; // Buton metnini geri döndür
                pictureBox1.Image = null;
            }
            else
            {
                MessageBox.Show("Yemek adı ve kalori değeri boş geçilemez");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu yemeği silmek istediğinizden emin misiniz?", "Yemek Silme Onayı", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                // Silme işlemini gerçekleştir
                string selectedFoodName = listBox1.SelectedItem.ToString();
                Food selectedFood = foodRepository.GetByName(selectedFoodName);

                if (selectedFood != null)
                {
                    foodRepository.Delete(selectedFood);
                    MessageBox.Show("Yemek başarıyla silindi.");

                    BringTheUpdatedFoodList();
                }
            }
        }

        private void BringTheUpdatedFoodList()
        {
            var foodNames = db.Foods.Select(f => f.Name).ToList();
            listBox1.DataSource = foodNames;
        }

        private void ClearFoodDetails()
        {
            txtFoodName.Text = "";
            nudCalorieValue.Value = 0;
            nudProtein.Value = 0;
            nudFat.Value = 0;
            nudCarb.Value = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tüm Dosyalar|*.*";
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
