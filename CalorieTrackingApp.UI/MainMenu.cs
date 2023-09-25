using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using CalorieTrackingApp.UI.Helper;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace CalorieTrackingApp.UI
{
    public partial class MainMenu : Form
    {
        Account account;
        public MainMenu(Account _account)
        {
            InitializeComponent();
            account = _account;
        }

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {
            Navigations.GotoConsumedFood(account, this);
            FillTheCaloriesPart();
            FillTheMacrosPart();
            FillTheMealStatistic();
            FillThePastOfCalorieDifference();
        }

        private void btnSuKaydet_Click(object sender, EventArgs e)
        {
            AddWaterIntake addWaterIntake = new AddWaterIntake(account);
            addWaterIntake.ShowDialog();
            FillTheWaterPart();
        }

        private void addWeight_btn_Click(object sender, EventArgs e)
        {
            AddWeightData addWeightData = new AddWeightData(account);
            addWeightData.Show();

        }

        private void profileLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navigations.GotoProfile(account, this);
        }

        private void reports_navBtn_Click(object sender, EventArgs e)
        {
            Navigations.GotoDailyReport(account, this);
        }

        private void reportsMonth_Click(object sender, EventArgs e)
        {
            Navigations.GotoLongReport(account, this);
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            Navigations.GotoSocial(account, this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Navigations.GotoExit(account, this);
        }


        ConsumedFoodRepository ConsumedFoodRepository;
        ConsumedWaterRepository ConsumedWaterRepository;
        List<ConsumedFood> consumedFoods;
        List<ConsumedWater> consumedWater;
        UserDetail userDetail;
        UserDetailRepository userDetails;
        Food _food;
        FoodRepository FoodRepository;
        private void MainMenu_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(254, 200, 77);
            //this.BackColor = Color.FromArgb(255, 189, 51);
            //btnSocial.BackColor = Color.FromArgb(255, 189, 20);
            btnSocial.FlatStyle = FlatStyle.System;
            ConsumedFoodRepository = new ConsumedFoodRepository();
            ConsumedWaterRepository = new ConsumedWaterRepository();
            FoodRepository = new FoodRepository();
            _food = new Food();

            userDetails = new UserDetailRepository();
            userDetail = userDetails.GetAll().Where(u => u.AccountId == account.Id).FirstOrDefault();
            FillTheCaloriesPart();
            FillTheMacrosPart();
            FillTheWaterPart();
            FillTheMealStatistic();
            FillThePastOfCalorieDifference();
            BasicTools.TopDetailFiller(topBar_groupBox.Controls, account.Id);
        }

        private void FillTheMealStatistic()
        {
            consumedFoods = ConsumedFoodRepository.GetAll().Where(a => a.ConsumedDate.Day == DateTime.Now.Day && a.ConsumedDate.Month == DateTime.Now.Month && a.AccountID == account.Id).ToList(); // Tarih kısmı değişecek
            #region Kahvaltı
            double kahvaltidaAlinanKalori = 0;
            foreach (var food in consumedFoods.Where(a => a.MealCategory == DATA.Enums.MealCategory.Breakfast))
            {
                _food = FoodRepository.GetAll().Where(a => a.Id == food.FoodID).FirstOrDefault();
                kahvaltidaAlinanKalori += _food.PortionCalorie * food.Portion;
            }
            lblKahvalti.Text = Math.Round((userDetail.TargetCalorieIntake * 50 / 100), 1).ToString() + "/" + Math.Round(kahvaltidaAlinanKalori, 1).ToString();
            lblKahvaltiYuzde.Text = Math.Round(((kahvaltidaAlinanKalori / (userDetail.TargetCalorieIntake * 50 / 100)) * 100), 1) > 100 ? "100" + "%" : Math.Round(((kahvaltidaAlinanKalori / (userDetail.TargetCalorieIntake * 50 / 100)) * 100), 1).ToString() + "%";
            breakfast_progressBar.Value = (int)((kahvaltidaAlinanKalori / (userDetail.TargetCalorieIntake * 50 / 100)) * 100) > 100 ? 100 : (int)((kahvaltidaAlinanKalori / (userDetail.TargetCalorieIntake * 50 / 100)) * 100);
            #endregion

            #region ÖğleYemeği
            double ogleYemegindeAlinanKalori = 0;
            foreach (var food in consumedFoods.Where(a => a.MealCategory == DATA.Enums.MealCategory.Lunch))
            {
                _food = FoodRepository.GetAll().Where(a => a.Id == food.FoodID).FirstOrDefault();
                ogleYemegindeAlinanKalori += _food.PortionCalorie * food.Portion;
            }
            lblOgleYemegi.Text = Math.Round((userDetail.TargetCalorieIntake * 30 / 100), 1).ToString() + "/" + Math.Round(ogleYemegindeAlinanKalori, 1).ToString();
            lblOgleYemegiYuzde.Text = Math.Round(((ogleYemegindeAlinanKalori / (userDetail.TargetCalorieIntake * 30 / 100)) * 100), 1) > 100 ? "100" + "%" : Math.Round(((ogleYemegindeAlinanKalori / (userDetail.TargetCalorieIntake * 30 / 100)) * 100), 1).ToString() + "%";
            lunch_progressBar.Value = (int)((ogleYemegindeAlinanKalori / (userDetail.TargetCalorieIntake * 30 / 100)) * 100) > 100 ? 100 : (int)((ogleYemegindeAlinanKalori / (userDetail.TargetCalorieIntake * 30 / 100)) * 100);
            #endregion

            #region AkşamYemeği
            double aksamYemegindeAlinanKalori = 0;
            foreach (var food in consumedFoods.Where(a => a.MealCategory == DATA.Enums.MealCategory.Dinner))
            {
                _food = FoodRepository.GetAll().Where(a => a.Id == food.FoodID).FirstOrDefault();
                aksamYemegindeAlinanKalori += _food.PortionCalorie * food.Portion;
            }
            lblAksamYemegi.Text = Math.Round((userDetail.TargetCalorieIntake * 20 / 100), 1).ToString() + "/" + Math.Round(aksamYemegindeAlinanKalori, 1).ToString();
            lblAksamYemegiYuzde.Text = Math.Round(((aksamYemegindeAlinanKalori / (userDetail.TargetCalorieIntake * 20 / 100)) * 100), 1) > 100 ? "100" + "%" : Math.Round(((aksamYemegindeAlinanKalori / (userDetail.TargetCalorieIntake * 20 / 100)) * 100), 1).ToString() + "%";
            dinner_progressBar.Value = (int)((aksamYemegindeAlinanKalori / (userDetail.TargetCalorieIntake * 20 / 100)) * 100) > 100 ? 100 : (int)((aksamYemegindeAlinanKalori / (userDetail.TargetCalorieIntake * 20 / 100)) * 100);
            #endregion
        }


        private void FillTheCaloriesPart()
        {
            consumedFoods = ConsumedFoodRepository.GetAll().Where(a => a.ConsumedDate.Day == DateTime.Now.Day && a.ConsumedDate.Month == DateTime.Now.Month && a.AccountID == account.Id).ToList(); // Tarih kısmı değişecek
            lblGunlukKaloriHedef.Text = Math.Round(userDetail.TargetCalorieIntake, 0).ToString() + "cal";

            double gunlukKalori = 0;
            foreach (var food in consumedFoods)
            {
                _food = FoodRepository.GetAll().Where(a => a.Id == food.FoodID).FirstOrDefault();
                gunlukKalori += (_food.PortionCalorie * food.Portion);  //O günkü yemeklerin kalorileri toplandı.
            }

            lblGunlukAlinanKalori.Text = Math.Round(gunlukKalori, 1).ToString() + "cal";
            lblKaloriAcigi.Text = Math.Round((userDetail.TargetCalorieIntake - gunlukKalori), 0).ToString() + "cal";
        }

        private void FillTheMacrosPart()
        {
            consumedFoods = ConsumedFoodRepository.GetAll().Where(a => a.ConsumedDate.Day == DateTime.Now.Day && a.ConsumedDate.Month == DateTime.Now.Month && a.AccountID == account.Id).ToList(); // Tarih kısmı değişecek
            double gunlukKarbonhidrat = 0;
            double gunlukProtein = 0;
            double gunlukYag = 0;

            foreach (var food in consumedFoods)
            {
                _food = FoodRepository.GetAll().Where(a => a.Id == food.FoodID).FirstOrDefault();
                gunlukKarbonhidrat += (_food.PortionCarb * food.Portion);
                gunlukProtein += (_food.PortionProtein * food.Portion);
                gunlukYag += (_food.PortionFat * food.Portion);
            }

            lblKarbonhidrat.Text = Math.Round(gunlukKarbonhidrat, 1).ToString() + "gr";
            lblProtein.Text = Math.Round(gunlukProtein, 1).ToString() + "gr";
            lblYag.Text = Math.Round(gunlukYag, 1).ToString() + "gr";
        }

        private void FillTheWaterPart()
        {

            userDetail = userDetails.GetAll().Where(u => u.AccountId == account.Id).FirstOrDefault();
            consumedWater = ConsumedWaterRepository.GetAll().Where(a => a.ConsumedTime.Day == DateTime.Now.Day && a.ConsumedTime.Month == DateTime.Now.Month && a.AccountID == account.Id).ToList(); // Tarih kısmı değişecek


            lblGunlukSuHedef.Text = userDetail.TargetWaterIntake.ToString() + "LT";
            double gunlukSu = 0;
            foreach (var water in consumedWater)
            {
                gunlukSu += water.Portion;
            }

            lblGunlukSuHedefKalan.Text = Math.Round((userDetail.TargetWaterIntake - gunlukSu), 2) <= 0 ? "0" + "LT" : Math.Round((userDetail.TargetWaterIntake - gunlukSu), 2).ToString() + "LT";
            lblYuzdeSu.Text = "%" + (Math.Round(((gunlukSu / userDetail.TargetWaterIntake) * 100), 1) > 100 ? "100" : Math.Round(((gunlukSu / userDetail.TargetWaterIntake) * 100), 1).ToString());
            waterIntake_progressBar.Value = (int)((gunlukSu / userDetail.TargetWaterIntake) * 100) > 100 ? 100 : (int)((gunlukSu / userDetail.TargetWaterIntake) * 100);
            lblGunlukSuIcilen.Text = Math.Round(gunlukSu, 2).ToString() + "LT";
        }




        private void FillThePastOfCalorieDifference()
        {
            DateTime date = DateTime.Now;
            for (int i = 0; i < 7; i++)
            {


                consumedFoods = ConsumedFoodRepository.GetAll()
                    .Where(a => a.ConsumedDate.Date.Day == date.Date.Day && a.ConsumedDate.Date.Day == date.Date.Day && a.AccountID == account.Id)
                    .ToList();

                double gunlukKalori = 0;
                foreach (var food in consumedFoods)
                {
                    _food = FoodRepository.GetAll().FirstOrDefault(a => a.Id == food.FoodID);
                    gunlukKalori += (_food.PortionCalorie * food.Portion);
                }

                // Update labels
                Label label = Controls.Find($"lblGun{7 - i}", true).FirstOrDefault() as Label;
                Label kaloriLabel = Controls.Find($"lblGun{7 - i}Kalori", true).FirstOrDefault() as Label;

                if (label != null && kaloriLabel != null)
                {
                    label.Text = date.ToString("dd/MM/yy");
                    kaloriLabel.Text = Math.Round((userDetail.TargetCalorieIntake - gunlukKalori), 0) + "cal";
                }

                date = date.AddDays(-1);
            }
        }

        private void btnSocial_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Navigations.GotoConsumedFood(account, this);
            FillTheCaloriesPart();
            FillTheMacrosPart();
            FillTheMealStatistic();
            FillThePastOfCalorieDifference();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Navigations.GotoConsumedFood(account, this);
            FillTheCaloriesPart();
            FillTheMacrosPart();
            FillTheMealStatistic();
            FillThePastOfCalorieDifference();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Navigations.GotoConsumedFood(account, this);
            FillTheCaloriesPart();
            FillTheMacrosPart();
            FillTheMealStatistic();
            FillThePastOfCalorieDifference();
        }
    }
}
