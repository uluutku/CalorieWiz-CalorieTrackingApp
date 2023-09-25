using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DATA.Entities;
using CalorieTrackingApp.DATA.Enums;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalorieTrackingApp.UI
{
    public partial class SignUpFillForm : Form
    {


        public SignUpFillForm()
        {
            InitializeComponent();
        }

        Account account;

        public SignUpFillForm(Account _account)
        {
            InitializeComponent();
            account = _account;
        }
        WeightHistoryRepository weightHistoryRepository;
        AccountRepository accountRepository;
        UserDetailRepository userRepository;
        string[] exercise = new string[] { "1-Hafif Aktivite", "2-Orta Aktivite", "3-Yüksek Aktivite" };
        private void SignUpFillForm_Load(object sender, EventArgs e)
        {

            GraphicsPath obj = new GraphicsPath();
            obj.AddEllipse(0, 0, pbUserPhoto.Width, pbUserPhoto.Height);
            Region rg = new Region(obj);
            pbUserPhoto.Region = rg;



            weightHistoryRepository = new WeightHistoryRepository();
            userRepository = new UserDetailRepository();
            accountRepository = new AccountRepository();
            nudHeightEntry.Value = 1.70m;
            nudWeightEntry.Value = 70;
            cmbExercise.SelectedItem = 0;
            rbMan.Checked = true;

            foreach (string item in exercise)
            {
                cmbExercise.Items.Add(item);

            }

        }


        UserDetail user;
        bool dontEntry = false;
        byte[] DefaultImage;
        private void btnSave_Click(object sender, EventArgs e)
        {


            if (nudHeightEntry.Value >= 0 && nudWeightEntry.Value >= 0 && nudTargetWeight.Value >= 0)
            {

                if (DateTime.Now.Year - dpBirthdate.Value.Year < 18)
                {
                    MessageBox.Show("Yaşınız 18 den büyük olmalı!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;

                }
                else
                {
                    Bitmap bitmap = rbMan.Checked ? CalorieTrackingApp.UI.Properties.Resources.defaultMale : CalorieTrackingApp.UI.Properties.Resources.defaultFemale;

                    using (MemoryStream stream = new MemoryStream())
                    {
                        bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                        DefaultImage = stream.ToArray();
                    }
                    Calculate();
                    user = new UserDetail();
                    user.Height = (double)nudHeightEntry.Value;
                    user.LastWeight = (double)nudWeightEntry.Value;
                    user.TargetWeight = (double)nudTargetWeight.Value;
                    WeightHistory wh = new WeightHistory()
                    {
                        AccountID = account.Id,
                        Weight = (double)nudWeightEntry.Value,
                        WeightDate = DateTime.Now,
                    };
                    weightHistoryRepository.Add(wh);
                    user.ExerciseLevel = aktiviteFaktoru;
                    user.BMI = bmi;
                    user.AccountId = account.Id;
                    user.TargetCalorieIntake = gunlukKaloriIhtiyaci;
                    user.Gender = rbMan.Checked ? (Gender)Enum.Parse(typeof(Gender), rbMan.Text) : (Gender)Enum.Parse(typeof(Gender), rbWoman.Text);
                    user.BirthDate = dpBirthdate.Value;
                    user.Picture = imagePath != null ? File.ReadAllBytes(imagePath) : DefaultImage;
                    userRepository.Add(user);
                    SignUpSuccess signUpSuccess = new SignUpSuccess(account, user);
                    this.Hide();
                    DialogResult dr = signUpSuccess.ShowDialog();
                    dontEntry = true;
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Zorunlu alanları doldurunuz!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }


        public static double bmi;
        public static double bazalMetabolizmaHizi;
        public static double gunlukKaloriIhtiyaci;
        public static double kiloVermeKalorisi;
        public static double kaloriAcigi;
        public static double aktiviteFaktoru;
        public void Calculate()
        {
            string cinsiyet = "";
            if (rbMan.Checked)
            {
                cinsiyet = "Erkek";
            }
            else if (rbWoman.Checked)
            {
                cinsiyet = "Kadın";
            }

            double boy = (double)nudHeightEntry.Value;
            double kilo = (double)nudWeightEntry.Value;
            double hedefKilo = (double)nudTargetWeight.Value;
            DateTime dogumTarihi = dpBirthdate.Value;
            int hareketSeviyesi = cmbExercise.SelectedIndex;

            // BMI hesaplaması
            bmi = Math.Round((kilo / ((boy) * (boy))), 2);


            bazalMetabolizmaHizi = (cinsiyet == "Erkek") ?
             66.47 + (13.75 * kilo) + (5 * boy * 100) - (6.76 * (DateTime.Now.Year - dogumTarihi.Year)) :
             655.10 + (9.56 * kilo) + (1.85 * boy * 100) - (4.68 * (DateTime.Now.Year - dogumTarihi.Year));


            switch (cmbExercise.SelectedIndex)
            {
                case 0: aktiviteFaktoru = 1.375; break; // Hafif aktivite
                case 1: aktiviteFaktoru = 1.55; break;  // Orta aktivite
                case 2: aktiviteFaktoru = 1.725; break; // Yüksek aktivite
                default: aktiviteFaktoru = 1.2; break;
            }

            gunlukKaloriIhtiyaci = bazalMetabolizmaHizi * aktiviteFaktoru;

            // Kilo vermek için günlük alınması gereken kalori hesaplaması
            kiloVermeKalorisi = gunlukKaloriIhtiyaci - (500);

            // Kalori açığı hesaplaması
            kaloriAcigi = gunlukKaloriIhtiyaci - kiloVermeKalorisi;

        }

        OpenFileDialog ofd;
        string imagePath;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "Image(png,jpg,jpeg)|*.jpeg;*.png;*.jpg;";
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pbUserPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                pbUserPhoto.Image = Image.FromFile(ofd.FileName);
            }
        }
        private void lkChancePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ofd = new OpenFileDialog();
            ofd.Filter = "Image(png,jpg,gif)|*.png;*.jpg;*.gif";
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pbUserPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                pbUserPhoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void SignUpFillForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (dontEntry == false)
            {
                DialogResult dr = MessageBox.Show("Kaydetmeden Çıkmak İstediğinize Emin misiniz ?", "BİLGİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {
                    accountRepository.Delete(account);
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }

            }


        }

        private void rbMan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMan.Checked)
            {
                pbUserPhoto.Image = CalorieTrackingApp.UI.Properties.Resources.defaultMale;
            }
            else
            {
                pbUserPhoto.Image = CalorieTrackingApp.UI.Properties.Resources.defaultFemale;
            }

        }
    }
}
