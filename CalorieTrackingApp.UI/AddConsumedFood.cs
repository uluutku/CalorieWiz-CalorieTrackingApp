using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using CalorieTrackingApp.DATA.Enums;
using CalorieTrackingApp.UI.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackingApp.UI
{
    public partial class AddConsumedFood : Form
    {
        private ProjectContext db;
        private FoodRepository foodRepository;
        private ConsumedFoodRepository consumedFoodRepository;
        Account account;
        DateTime date = DateTime.Now;
        public AddConsumedFood(Account _account)
        {
            InitializeComponent();
            consumedFoodRepository = new ConsumedFoodRepository();
            account = _account;
        }
        private string defaultText = "Aranacak yemek giriniz";

        private void AddConsumedFood_Load(object sender, EventArgs e)
        {
            dtpConsumeDate.MaxDate = DateTime.Now;
            BasicTools.TopDetailFiller(topBar_groupBox.Controls, account.Id);
            db = new ProjectContext();
            foodRepository = new FoodRepository();
            var foodNames = db.Foods.Select(f => f.Name).ToList();
            listBox1.DataSource = foodNames;
            textBox1.Text = defaultText;
            lblPortionNumber.Text = string.Concat((nudPortionNumber.Value * 100.0m).ToString(), " Gram");
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)  // Lboxta secili bir oge var mi?
            {
                string selectedFoodName = listBox1.SelectedItem.ToString();
                Food selectedFood = foodRepository.GetByName(selectedFoodName);
                nudPortionNumber.Value = 1;

                double portionNum = (double)nudPortionNumber.Value;
                if (selectedFood != null)
                {
                    lblFoodName.Text = selectedFoodName;
                    lblCalorie.Text = Math.Round(selectedFood.PortionCalorie * portionNum, 1).ToString() + "cal";
                    lblCarb.Text = Math.Round(selectedFood.PortionCarb * portionNum, 1).ToString() + "gr";
                    lblFat.Text = Math.Round(selectedFood.PortionFat * portionNum, 1).ToString() + "gr";
                    lblProtein.Text = Math.Round(selectedFood.PortionProtein * portionNum, 1).ToString() + "gr";

                    // Resmi yükle
                    if (selectedFood.Photo != null)
                    {
                        using (MemoryStream ms = new MemoryStream(selectedFood.Photo))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBox1.Image = CalorieTrackingApp.UI.Properties.Resources.DefaultFood;
                    }

                    GraphicsPath obj = new GraphicsPath();
                    obj.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
                    Region rg = new Region(obj);
                    pictureBox1.Region = rg;

                }
            }
        }

        private void nudPortionNumber_ValueChanged(object sender, EventArgs e)
        {
            lblPortionNumber.Text = string.Concat((nudPortionNumber.Value * 100.0m).ToString(), " Gram");
            if (listBox1.SelectedIndex != -1)
            {
                string selectedFoodName = listBox1.SelectedItem.ToString();
                Food selectedFood = foodRepository.GetByName(selectedFoodName);

                if (selectedFood != null)
                {
                    double portionAmount = (double)nudPortionNumber.Value;
                    lblCalorie.Text = Math.Round(selectedFood.PortionCalorie * portionAmount, 1).ToString() + "cal";
                    lblCarb.Text = Math.Round(selectedFood.PortionCarb * portionAmount, 1).ToString() + "gr";
                    lblFat.Text = Math.Round(selectedFood.PortionFat * portionAmount, 1).ToString() + "gr";
                    lblProtein.Text = Math.Round(selectedFood.PortionProtein * portionAmount, 1).ToString() + "gr";
                }
            }
        }

        private void btnSaveToConsumedFood_Click(object sender, EventArgs e)
        {
            // Seçilen radio buttona göre MealCategory değerini ayarla
            MealCategory mealCategory = new MealCategory(); // Varsayılan olarak Other (Diğer) ayarlandi
            switch (true)
            {
                case bool _ when rbBreakfast.Checked:
                    mealCategory = MealCategory.Breakfast;
                    break;

                case bool _ when rbLunch.Checked:
                    mealCategory = MealCategory.Lunch;
                    break;

                case bool _ when rbDinner.Checked:
                    mealCategory = MealCategory.Dinner;
                    break;

                default:
                    MessageBox.Show("Kaydetmek istediginiz ogunu secmelisiniz!");
                    return;
            }



            // secilen yemegi yakala
            string selectedFoodName = listBox1.SelectedItem.ToString();
            Food selectedFood = foodRepository.GetByName(selectedFoodName);

            consumedFoodRepository = new ConsumedFoodRepository();

            if (selectedFood != null)
            {

                ConsumedFood consumedFood = new ConsumedFood()
                {
                    FoodID = selectedFood.Id,
                    ConsumedDate = date,
                    ConsumedTime = date,
                    Portion = (double)nudPortionNumber.Value,
                    Photo = selectedFood.Photo,
                    AccountID = account.Id,
                    MealCategory = mealCategory

                };

                // consumedFoodRepository üzerinden kaydet
                consumedFoodRepository.Add(consumedFood);
                MessageBox.Show("Yemek kaydedildi!");
                consumedFood.ConsumedCount += (int)nudPortionNumber.Value;
                consumedFoodRepository.Update(consumedFood);

            }
        }

        private void btnAddNewFood_Click(object sender, EventArgs e)
        {
            AddFoodToSystem addFoodForm = new AddFoodToSystem();
            addFoodForm.StartPosition = FormStartPosition.CenterParent;
            addFoodForm.ShowDialog();
        }



        // Yukaridan gelecek Account'a gore burasi belki duzenlenebilir:
        private UserDetail GetUserDetailForCurrentUser()
        {
            try
            {
                //int accountId = 4; // Mevcut kullanıcının hesap kimliği
                int accountId = account.Id; // Mevcut kullanıcının hesap kimliği

                using (var dbContext = new ProjectContext()) // Veritabanı bağlantısını oluşturun
                {
                    // Kullanıcı ayrıntılarını veritabanından alın
                    var userDetail = dbContext.UserDetails
                        .FirstOrDefault(u => u.AccountId == accountId);

                    return userDetail;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı ayrıntıları alınırken bir hata oluştu. Lütfen sistem yöneticinizle iletişime geçin veya daha sonra tekrar deneyin. Hata detayı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void lblAllergenIngredient_Click(object sender, EventArgs e)
        {

        }

        private void mainMenu_navBtn_Click(object sender, EventArgs e)
        {
            DailyReport dailyReport = new DailyReport(account);
            dailyReport.MdiParent = (MdiParent as SubMenuMDI);
            (MdiParent as SubMenuMDI).Size = new Size(dailyReport.Width, dailyReport.Height);
            dailyReport.FormBorderStyle = FormBorderStyle.None;
            dailyReport.Dock = DockStyle.Fill;
            dailyReport.Show();
            //CloseMDIs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Navigations.GotoLongReport(account, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Navigations.GotoSocial(account, this);
        }

        private void mainMenu_navBtn_Click_1(object sender, EventArgs e)
        {
            Navigations.GotoMainMenu(account, this);
        }

        private void reports_navBtn_Click(object sender, EventArgs e)
        {
            Navigations.GotoDailyReport(account, this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Navigations.GotoExit(account, this);
        }

        private void dtpConsumeDate_ValueChanged(object sender, EventArgs e)
        {
            date = dtpConsumeDate.Value;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void topBar_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void lblProfileNameTop1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navigations.GotoProfile(account, this);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
