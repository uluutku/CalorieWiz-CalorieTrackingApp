using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DATA.Entities;
using CalorieTrackingApp.UI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackingApp.UI
{
    public partial class Profile : Form
    {
        string imagePath;
        Account _account;
        UserDetail userDetail;
        WeightHistoryRepository weightHistories;
        UserDetailRepository userDetails;
        AccountRepository accounts;
        public Profile(Account account)
        {
            _account = account;
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            accounts = new AccountRepository();
            userDetails = new UserDetailRepository();
            userDetail = userDetails.GetAll().Where(u => u.AccountId == _account.Id).FirstOrDefault();
            weightHistories = new WeightHistoryRepository();

            //Resmi yuvarlama
            GraphicsPath obj = new GraphicsPath();
            obj.AddEllipse(0, 0, pbProfilePicture.Width, pbProfilePicture.Height);
            Region rg = new Region(obj);
            pbProfilePicture.Region = rg;

            UpdateAllVAlues();
        }

        //Verileri güncelliyor
        private void UpdateAllVAlues()
        {
            if (userDetail != null)
            {
                if (userDetail.Picture != null)
                {
                    using (MemoryStream ms = new MemoryStream(userDetail.Picture))
                    {
                        pbProfilePicture.Image = Image.FromStream(ms);
                    }
                }
                lblHeight.Text = (userDetail.Height * 100).ToString() + "cm";
                lblWeight.Text = userDetail.LastWeight.ToString() + "Kg";
                lblBMI.Text = userDetail.BMI.ToString();
                lblBMICondition.Text = BMICondition(userDetail.BMI);
                lblTargetWeight.Text = Math.Round(userDetail.TargetWeight, 2).ToString() + "Kg";
                lblRemainTarget.Text = Math.Round(userDetail.TargetWeight - userDetail.LastWeight, 2).ToString();
                lblDailyGoal.Text = Math.Round(userDetail.TargetCalorieIntake, 2).ToString() + "Kcal";
                lblBDay.Text = $"{userDetail.BirthDate.Day}/{userDetail.BirthDate.Month}/{userDetail.BirthDate.Year}";
            }
            lblName.Text = _account.Name;
            lblEMail.Text = _account.EMail;
            lblTopName.Text = BasicTools.FirstLatterUpper(_account.Name);

        }
        //BMI durum yazısı
        private string BMICondition(double bMI)
        {
            switch (bMI)
            {
                case var x when x < 16:
                    return "Aşırı İnce";

                case var x when x >= 16 && x < 17:
                    return "Orta İnce";

                case var x when x >= 17 && x < 18.5:
                    return "Hafif İnce";

                case var x when x >= 18.5 && x < 25:
                    return "Normal";

                case var x when x >= 25 && x < 30:
                    return "Kilolu";

                case var x when x >= 30 && x < 35:
                    return "Obez Sınıf I";

                case var x when x >= 35 && x < 40:
                    return "Obez Sınıf II";

                default:
                    return "Obez Sınıf III";
            }
        }

        //Fiziksel veriler düzenle ve kaydet butonu
        private void btnEditAnddone_Click(object sender, EventArgs e)
        {
            if (btnEditAnddone.Text == "Düzenle")
            {
                btnEditAnddone.Text = "Kaydet";
                lblWeight.Visible = false;
                lblHeight.Visible = false;
                lblTargetWeight.Visible = false;
                lblDailyGoal.Visible = false;
                numHeight.Visible = true;
                numTargetCalorie.Visible = true;
                numWeight.Visible = true;
                numTargetWeight.Visible = true;
                numHeight.Value = (decimal)userDetail.Height * 100;
                numTargetCalorie.Value = (decimal)userDetail.TargetCalorieIntake;
                numWeight.Value = (decimal)userDetail.LastWeight;
                numTargetWeight.Value = (decimal)userDetail.TargetWeight;
                btnBack.Visible = true;
                btnEditAnddone.Enabled = false;
            }
            else
            {
                DialogResult res = MessageBox.Show("Yapılan değişiklikleri kaydetmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    //numerical updown değerlerini set eder.
                    NumSave();
                    btnEditAnddone.Text = "Düzenle";
                    lblWeight.Visible = true;
                    lblHeight.Visible = true;
                    lblTargetWeight.Visible = true;
                    lblDailyGoal.Visible = true;
                    numHeight.Visible = false;
                    numTargetCalorie.Visible = false;
                    numWeight.Visible = false;
                    numTargetWeight.Visible = false;
                    btnBack.Visible = false;
                }
            }

        }
        //Database kaydetme işlemleri
        private void NumSave()
        {
            userDetail.Height = (double)numHeight.Value / 100.0;
            userDetail.LastWeight = (double)numWeight.Value;
            WeightHistory weightHistory = new WeightHistory()
            {
                Weight = (double)numWeight.Value,
                AccountID = _account.Id,
                WeightDate = DateTime.Now,

            };
            weightHistories.Add(weightHistory);
            userDetail.BMI = Math.Round(((double)numWeight.Value / (Math.Pow(((double)numHeight.Value / 100.0), 2))), 2);
            userDetail.TargetWeight = (double)numTargetWeight.Value;
            userDetail.TargetCalorieIntake = (double)numTargetCalorie.Value;
            userDetails.Update(userDetail);
            UpdateAllVAlues();
        }

        private void numWeight_ValueChanged(object sender, EventArgs e)
        {
            lblRemainTarget.Text = (numTargetWeight.Value - numWeight.Value).ToString() + "Kg";
            double BMIValue = Math.Round(((double)numWeight.Value / (Math.Pow(((double)numHeight.Value / 100.0), 2))), 2);
            lblBMI.Text = BMIValue.ToString() + "Kg";
            lblBMICondition.Text = BMICondition(BMIValue);
            btnEditAnddone.Enabled = true;
        }

        private void numTargetWeight_ValueChanged(object sender, EventArgs e)
        {
            lblRemainTarget.Text = (numTargetWeight.Value - numWeight.Value).ToString() + "Kg";
            btnEditAnddone.Enabled = true;

        }

        private void numHeight_ValueChanged(object sender, EventArgs e)
        {
            double BMIValue = Math.Round(((double)numWeight.Value / (Math.Pow(((double)numHeight.Value / 100.0), 2))), 2);
            lblBMI.Text = BMIValue.ToString() + "Kg";
            lblBMICondition.Text = BMICondition(BMIValue);
            btnEditAnddone.Enabled = true;

        }
        //Yapılan değişiklikleri kadetmeden çıkmak
        private void btnBack_Click(object sender, EventArgs e)
        {
            lblRemainTarget.Text = (userDetail.TargetWeight - userDetail.LastWeight).ToString();
            lblBMI.Text = userDetail.BMI.ToString();
            lblBMICondition.Text = BMICondition(userDetail.BMI);
            btnEditAnddone.Text = "Düzenle";
            btnEditAnddone.Enabled = true;
            lblWeight.Visible = true;
            lblHeight.Visible = true;
            lblTargetWeight.Visible = true;
            lblDailyGoal.Visible = true;
            numHeight.Visible = false;
            numTargetCalorie.Visible = false;
            numWeight.Visible = false;
            numTargetWeight.Visible = false;
            btnBack.Visible = false;
        }

        private void pbProfilePicture_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pbProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                pbProfilePicture.Image = Image.FromFile(ofd.FileName);
                btnSaveChanges.Visible = true;
                pbEdit.Visible = false;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            btnSaveChanges.Visible = false;
            userDetail.Picture = File.ReadAllBytes(imagePath);
            userDetails.Update(userDetail);
            pbEdit.Visible = true;
        }
        //
        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            if (btnEditAccount.Text == "Düzenle")
            {
                btnEditAccount.Text = "Kaydet";
                btnBack2.Visible = true;
                txtName.Visible = true;
                dtBDay.Visible = true;
                lblName.Visible = false;
                lblBDay.Visible = false;
                txtName.Text = _account.Name;
                if (userDetail.BirthDate != null)
                {
                    dtBDay.Value = userDetail.BirthDate;
                }

            }
            else
            {
                if (txtName.Text != "")
                {
                    DialogResult res = MessageBox.Show("Yapılan değişiklikleri kaydetmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        //account verilerini set eder.
                        AccountSave();
                        btnEditAccount.Text = "Düzenle";
                        txtName.Visible = false;
                        dtBDay.Visible = false;
                        lblName.Visible = true;
                        lblBDay.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen isim satırını boş bırakmayınız", "Eksik öğe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void AccountSave()
        {
            _account.Name = txtName.Text;
            accounts.Update(_account);
            userDetail.BirthDate = dtBDay.Value;
            userDetails.Update(userDetail);
            UpdateAllVAlues();
            lblTopName.Text = BasicTools.FirstLatterUpper(txtName.Text);
        }

        //Account tarafındaki değişiklikleri geri alır.
        private void btnBack2_Click(object sender, EventArgs e)
        {
            btnEditAccount.Text = "Düzenle";
            txtName.Visible = false;
            dtBDay.Visible = false;
            lblName.Visible = true;
            lblBDay.Visible = true;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PPasswordChange pcForm = new PPasswordChange(_account);
            pcForm.Size = new Size(447, 626);
            pcForm.ShowDialog();

        }

        private void exit_navbar_Click(object sender, EventArgs e)
        {
            Navigations.GotoExit(_account, this);
        }

        private void reports_navBtn_Click(object sender, EventArgs e)
        {
            Navigations.GotoDailyReport(_account, this);
        }

        private void longReport_navbar_Click(object sender, EventArgs e)
        {
            Navigations.GotoLongReport(_account, this);
        }

        private void social_navbar_Click(object sender, EventArgs e)
        {
            Navigations.GotoSocial(_account, this);
        }

        private void mainMenu_navBtn_Click(object sender, EventArgs e)
        {
            Navigations.GotoMainMenu(_account, this);
        }
    }
}
