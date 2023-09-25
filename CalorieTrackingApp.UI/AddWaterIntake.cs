using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackingApp.UI
{
    public partial class AddWaterIntake : Form
    {
        private Account account;


        public AddWaterIntake(Account account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        ConsumedWaterRepository ConsumedWaterRepository;
        ConsumedWater ConsumedWater;
        private void AddWaterIntake_Load(object sender, EventArgs e)
        {
            dtpDate.MaxDate = DateTime.Now;
            ConsumedWaterRepository = new ConsumedWaterRepository();
            FillInTheTexts(); //Label ve Progress Bar Doldur
            if (ConsumedWaterRepository.GetAll().Where(a => a.ConsumedTime.Day == DateTime.Now.Day && a.ConsumedTime.Month == DateTime.Now.Month).Count() == 0)
            {
                btnRemove.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
            }


        }

        List<ConsumedWater> consumedWater;
        private void FillInTheTexts() //Labellar ve Progress Bar'ın doldurulması için yazılmış metot.
        {
            consumedWater = ConsumedWaterRepository.GetAll().Where(a => a.ConsumedTime.Day == dtpDate.Value.Day && a.ConsumedTime.Month == dtpDate.Value.Month && a.AccountID == account.Id).ToList(); // Tarih kısmı değişecek
            UserDetail userDetail = new UserDetail();
            UserDetailRepository userDetails = new UserDetailRepository();
            userDetail = userDetails.GetAll().Where(u => u.AccountId == account.Id).FirstOrDefault();


            double gunlukSu = 0;
            foreach (var water in consumedWater)
            {
                gunlukSu += water.Portion;
            }
            lblGunlukSuHedefKalan.Text = Math.Round((userDetail.TargetWaterIntake - gunlukSu), 2) <= 0 ? "0" + "LT" : Math.Round((userDetail.TargetWaterIntake - gunlukSu), 2).ToString() + "LT";
            lblGunlukSuHedef.Text = userDetail.TargetWaterIntake.ToString() + "LT";

            lblYuzdeSu.Text = "%" + (Math.Round(((gunlukSu / userDetail.TargetWaterIntake) * 100), 1) > 100 ? "100" : Math.Round(((gunlukSu / userDetail.TargetWaterIntake) * 100), 1).ToString());
            waterIntake_progressBar.Value = (int)((gunlukSu / userDetail.TargetWaterIntake) * 100) > 100 ? 100 : (int)((gunlukSu / userDetail.TargetWaterIntake) * 100);

            lblGunlukSuIcilen.Text = Math.Round(gunlukSu, 2).ToString() + "LT";

            rb250.Checked = false;
            rb500.Checked = false;
            rb1000.Checked = false;
            nudAlinanSu.Value = 0;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            #region Seçilen ComboBox ya da Num.UpDown'a göre su ekleme
            double portion = 0;

            if (nudAlinanSu.Value != 0)
            {
                portion = (double)nudAlinanSu.Value;
            }
            else if (rb250.Checked)
            {
                portion = 0.25;
            }
            else if (rb500.Checked)
            {
                portion = 0.50;
            }
            else if (rb1000.Checked)
            {
                portion = 1;
            }
            else
            {
                MessageBox.Show("Lütfen Alınan Su Miktarını Giriniz!");
                return;
            }

            ConsumedWater = new ConsumedWater() //İçilen suyu eklemek için yeni bir consumedWater oluşturuyoruz.
            {
                Portion = portion,
                ConsumedTime = dtpDate.Value,
                AccountID = account.Id
            };

            ConsumedWaterRepository.Add(ConsumedWater);

            #endregion

            FillInTheTexts(); //Label ve Progress Bar Doldur           
            btnRemove.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ConsumedWater = new ConsumedWater();
            ConsumedWater = ConsumedWaterRepository.GetAll().OrderByDescending(a => a.ConsumedTime).First(a => a.ConsumedTime.Day == dtpDate.Value.Day && a.ConsumedTime.Month == dtpDate.Value.Month);
            ConsumedWaterRepository.Delete(ConsumedWater);
            FillInTheTexts(); //Label ve Progress Bar Doldur  
            if (ConsumedWaterRepository.GetAll().Where(a => a.ConsumedTime.Day == dtpDate.Value.Day && a.ConsumedTime.Month == dtpDate.Value.Month).Count() == 0)
            {
                btnRemove.Enabled = false;
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

            if (ConsumedWaterRepository.GetAll().Where(a => a.ConsumedTime.Day == dtpDate.Value.Day && a.ConsumedTime.Month == dtpDate.Value.Month).Count() == 0)
            {
                btnRemove.Enabled = false;
            }
            else
            {
                btnRemove.Enabled = true;
            }
            FillInTheTexts(); //Label ve Progress Bar Doldur
        }

        private void nudAlinanSu_ValueChanged(object sender, EventArgs e)
        {
            rb250.Enabled = false;
            rb500.Enabled = false;
            rb1000.Enabled = false;
            rb250.Checked = false;
            rb500.Checked = false;
            rb1000.Checked = false;
            if (nudAlinanSu.Value == 0)
            {
                rb250.Enabled = true;
                rb500.Enabled = true;
                rb1000.Enabled = true;
                rb250.Checked = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }
    }
}
