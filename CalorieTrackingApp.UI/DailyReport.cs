using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using CalorieTrackingApp.UI.Helper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackingApp.UI
{
    public partial class DailyReport : Form
    {
        private ProjectContext db;
        private ConsumedFoodRepository cFoodRepository;
        private FoodRepository FoodRepository;
        Food _food;
        Account account;
        List<ConsumedFood> consumedFoods;


        public DailyReport()
        {
            InitializeComponent();
        }

        public DailyReport(Account _account)
        {
            InitializeComponent();
            account = _account;
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            BasicTools.TopDetailFiller(topBar_groupBox.Controls, account.Id);
            db = new ProjectContext();
            cFoodRepository = new ConsumedFoodRepository();
            FoodRepository = new FoodRepository();
            BringTheUpdatedFoodList();
            FillTheMacrosPart();
            FillTheMacrosForBreakfast();
            FillTheMacrosForLunch();
            FillTheMacrosForDinner();
            btnForward.Enabled = false;

        }

        private void BringTheUpdatedFoodList()
        {
            DateTime selectedDate = dateTimePicker1.Value;

            if (rbBreakfast.Checked)
            {
                var cfoodNames = (from cf in db.ConsumedFoods
                                  join f in db.Foods on cf.FoodID equals f.Id
                                  where cf.ConsumedDate.Day == selectedDate.Day &&
                                        cf.ConsumedDate.Month == selectedDate.Month &&
                                        cf.AccountID == account.Id &&
                                        cf.MealCategory == DATA.Enums.MealCategory.Breakfast
                                  select string.Concat(f.Name, " - ", cf.MealCategory, " - ", f.PortionCalorie * cf.ConsumedCount, "cal")).ToList();
                listBox1.DataSource = cfoodNames;
                groupBox3.BackColor = Color.FromArgb(173, 216, 230);
                groupBox2.BackColor = default;
                groupBox4.BackColor = default;
                groupBox5.BackColor = default;
                button6.Enabled = true;

            }

            else if (rbLuch.Checked)
            {
                var cfoodNames = (from cf in db.ConsumedFoods
                                  join f in db.Foods on cf.FoodID equals f.Id
                                  where cf.ConsumedDate.Day == selectedDate.Day &&
                                        cf.ConsumedDate.Month == selectedDate.Month &&
                                        cf.AccountID == account.Id &&
                                        cf.MealCategory == DATA.Enums.MealCategory.Lunch
                                  select string.Concat(f.Name, " - ", cf.MealCategory, " - ", f.PortionCalorie * cf.ConsumedCount, "cal")).ToList();
                listBox1.DataSource = cfoodNames;
                groupBox2.BackColor = Color.FromArgb(173, 216, 230);
                groupBox5.BackColor = default;
                groupBox3.BackColor = default;
                groupBox4.BackColor = default;
                button6.Enabled = true;

            }

            else if (rbDinner.Checked)
            {
                var cfoodNames = (from cf in db.ConsumedFoods
                                  join f in db.Foods on cf.FoodID equals f.Id
                                  where cf.ConsumedDate.Day == selectedDate.Day &&
                                        cf.ConsumedDate.Month == selectedDate.Month &&
                                        cf.AccountID == account.Id &&
                                        cf.MealCategory == DATA.Enums.MealCategory.Dinner
                                  select string.Concat(f.Name, " - ", cf.MealCategory, " - ", f.PortionCalorie * cf.ConsumedCount, "cal")).ToList();

                listBox1.DataSource = cfoodNames;
                groupBox4.BackColor = Color.FromArgb(173, 216, 230);
                groupBox2.BackColor = default;
                groupBox3.BackColor = default;
                groupBox5.BackColor = default;
                button6.Enabled = true;


            }

            else if (rbAll.Checked)
            {
                var cfoodNames = (from cf in db.ConsumedFoods
                                  join f in db.Foods on cf.FoodID equals f.Id
                                  where cf.ConsumedDate.Day == selectedDate.Day &&
                                        cf.AccountID == account.Id &&
                                        cf.ConsumedDate.Month == selectedDate.Month
                                  select string.Concat(f.Name, " - ", cf.MealCategory, " - ", f.PortionCalorie * cf.ConsumedCount, "cal")).ToList();
                listBox1.DataSource = cfoodNames;
                groupBox5.BackColor = Color.FromArgb(173, 216, 230);
                groupBox2.BackColor = default;
                groupBox3.BackColor = default;
                groupBox4.BackColor = default;
                button6.Enabled = false;
            }

            else
            {
                rbAll.Checked = true;
                BringTheUpdatedFoodList();
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BringTheUpdatedFoodList();
        }

        private void rbBreakfast_CheckedChanged(object sender, EventArgs e)
        {
            BringTheUpdatedFoodList();
        }

        private void rbLuch_CheckedChanged(object sender, EventArgs e)
        {
            BringTheUpdatedFoodList();
        }

        private void rbDinner_CheckedChanged(object sender, EventArgs e)
        {
            BringTheUpdatedFoodList();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            BringTheUpdatedFoodList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu yemeği silmek istediğinizden emin misiniz?", "Yemek Silme Onayı", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (rbDinner.Checked)
                {
                    Food food = FoodRepository.GetAll().FirstOrDefault(x => x.Name == listBox1.SelectedItem.ToString().Split('-')[0].Trim());
                    ConsumedFood selectedFoodObject = cFoodRepository.GetAll().FirstOrDefault(x => x.MealCategory == DATA.Enums.MealCategory.Dinner && x.FoodID == food.Id);

                    if (selectedFoodObject != null)
                    {
                        cFoodRepository.Delete(selectedFoodObject);
                        MessageBox.Show("Yemek başarıyla silindi.");
                        ResetMealControls(selectedFoodObject.MealCategory.ToString());
                        BringTheUpdatedFoodList();
                        FillTheMacrosPart();
                        FillTheMacrosForBreakfast();
                        FillTheMacrosForLunch();
                        FillTheMacrosForDinner();
                    }
                }

                if (rbLuch.Checked)
                {

                    Food food = FoodRepository.GetAll().FirstOrDefault(x => x.Name == listBox1.SelectedItem.ToString().Split('-')[0].Trim());
                    ConsumedFood selectedFoodObject = cFoodRepository.GetAll().FirstOrDefault(x => x.MealCategory == DATA.Enums.MealCategory.Lunch && x.FoodID == food.Id);

                    if (selectedFoodObject != null)
                    {
                        cFoodRepository.Delete(selectedFoodObject);
                        MessageBox.Show("Yemek başarıyla silindi.");
                        ResetMealControls(selectedFoodObject.MealCategory.ToString());
                        BringTheUpdatedFoodList();
                        FillTheMacrosPart();
                        FillTheMacrosForBreakfast();
                        FillTheMacrosForLunch();
                        FillTheMacrosForDinner();
                    }
                }

                if (rbBreakfast.Checked)
                {
                    Food food = FoodRepository.GetAll().FirstOrDefault(x => x.Name == listBox1.SelectedItem.ToString().Split('-')[0].Trim());
                    ConsumedFood selectedFoodObject = cFoodRepository.GetAll().FirstOrDefault(x => x.MealCategory == DATA.Enums.MealCategory.Breakfast && x.FoodID == food.Id);

                    if (selectedFoodObject != null)
                    {
                        cFoodRepository.Delete(selectedFoodObject);
                        MessageBox.Show("Yemek başarıyla silindi.");
                        ResetMealControls(selectedFoodObject.MealCategory.ToString());
                        BringTheUpdatedFoodList();
                        FillTheMacrosPart();
                        FillTheMacrosForBreakfast();
                        FillTheMacrosForLunch();
                        FillTheMacrosForDinner();
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;

            if (selectedDate < DateTime.Now)
            {
                dateTimePicker1.Value = selectedDate.AddDays(-1);
                btnForward.Enabled = true;

            }
            FillTheMacrosPart();
            FillTheMacrosForBreakfast();
            FillTheMacrosForLunch();
            FillTheMacrosForDinner();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;

            if (selectedDate.Day == DateTime.Now.Day)
            {
                btnForward.Enabled = false;
            }
            else
            {
                btnForward.Enabled = true;
                dateTimePicker1.Value = selectedDate.AddDays(1);
            }
            FillTheMacrosPart();
            FillTheMacrosForBreakfast();
            FillTheMacrosForLunch();
            FillTheMacrosForDinner();
        }

        private void FillTheMacrosPart()
        {
            _food = new Food();
            FoodRepository = new FoodRepository();
            consumedFoods = cFoodRepository.GetAll().Where(a => a.ConsumedDate.Day == dateTimePicker1.Value.Day && a.ConsumedDate.Month == dateTimePicker1.Value.Month && a.AccountID == account.Id).ToList(); // --account.Id
            double gunlukKarbonhidrat = 0;
            double gunlukProtein = 0;
            double gunlukYag = 0;
            double gunlukKalori = 0;

            foreach (var food in consumedFoods)
            {
                _food = FoodRepository.GetAll().Where(a => a.Id == food.FoodID).FirstOrDefault();
                gunlukKarbonhidrat += (_food.PortionCarb * food.Portion);
                gunlukProtein += (_food.PortionProtein * food.Portion);
                gunlukYag += (_food.PortionFat * food.Portion);
                gunlukKalori += (_food.PortionCalorie * food.Portion);
            }

            lblKarbonhidrat.Text = Math.Round(gunlukKarbonhidrat, 1).ToString() + " gr";
            lblProtein.Text = Math.Round(gunlukProtein, 1).ToString() + " gr";
            lblYag.Text = Math.Round(gunlukYag, 1).ToString() + " gr";
            lblKalori.Text = Math.Round(gunlukKalori, 1).ToString() + " cal";
        }

        private void FillTheMacrosForBreakfast()
        {
            _food = new Food();
            FoodRepository = new FoodRepository();
            consumedFoods = cFoodRepository.GetAll().Where(a => a.ConsumedDate.Day == dateTimePicker1.Value.Day && a.ConsumedDate.Month == dateTimePicker1.Value.Month && a.AccountID == account.Id).ToList(); // Tarih kısmı değişecek   --account.Id
            double gunlukKarbonhidrat = 0;
            double gunlukProtein = 0;
            double gunlukYag = 0;
            double gunlukKalori = 0;

            foreach (var food in consumedFoods.Where(a => a.MealCategory == DATA.Enums.MealCategory.Breakfast))
            {
                _food = FoodRepository.GetAll().Where(a => a.Id == food.FoodID).FirstOrDefault();
                gunlukKarbonhidrat += (_food.PortionCarb * food.Portion);
                gunlukProtein += (_food.PortionProtein * food.Portion);
                gunlukYag += (_food.PortionFat * food.Portion);
                gunlukKalori += (_food.PortionCalorie * food.Portion);
            }

            lblKarbonhidratKahvalti.Text = Math.Round(gunlukKarbonhidrat, 1).ToString() + " gr";
            lblProteinKahvalti.Text = Math.Round(gunlukProtein, 1).ToString() + " gr";
            lblYagKahvalti.Text = Math.Round(gunlukYag, 1).ToString() + " gr";
            lblKaloriKahvalti.Text = Math.Round(gunlukKalori, 1).ToString() + " cal";
        }

        private void FillTheMacrosForLunch()
        {
            _food = new Food();
            FoodRepository = new FoodRepository();
            consumedFoods = cFoodRepository.GetAll().Where(a => a.ConsumedDate.Day == dateTimePicker1.Value.Day && a.ConsumedDate.Month == dateTimePicker1.Value.Month && a.AccountID == account.Id).ToList(); // Tarih kısmı değişecek   --account.Id
            double gunlukKarbonhidrat = 0;
            double gunlukProtein = 0;
            double gunlukYag = 0;
            double gunlukKalori = 0;

            foreach (var food in consumedFoods.Where(a => a.MealCategory == DATA.Enums.MealCategory.Lunch))
            {
                _food = FoodRepository.GetAll().Where(a => a.Id == food.FoodID).FirstOrDefault();
                gunlukKarbonhidrat += (_food.PortionCarb * food.Portion);
                gunlukProtein += (_food.PortionProtein * food.Portion);
                gunlukYag += (_food.PortionFat * food.Portion);
                gunlukKalori += (_food.PortionCalorie * food.Portion);
            }

            lblKarbonhidratOgleYemegi.Text = Math.Round(gunlukKarbonhidrat, 1).ToString() + " gr";
            lblProteinOgleYemegi.Text = Math.Round(gunlukProtein, 1).ToString() + " gr";
            lblYagOgleYemegi.Text = Math.Round(gunlukYag, 1).ToString() + " gr";
            lblKaloriOgleYemegi.Text = Math.Round(gunlukKalori, 1).ToString() + " cal";
        }

        private void FillTheMacrosForDinner()
        {
            _food = new Food();
            FoodRepository = new FoodRepository();
            consumedFoods = cFoodRepository.GetAll().Where(a => a.ConsumedDate.Day == dateTimePicker1.Value.Day && a.ConsumedDate.Month == dateTimePicker1.Value.Month && a.AccountID == account.Id).ToList(); // Tarih kısmı değişecek   --account.Id
            double gunlukKarbonhidrat = 0;
            double gunlukProtein = 0;
            double gunlukYag = 0;
            double gunlukKalori = 0;

            foreach (var food in consumedFoods.Where(a => a.MealCategory == DATA.Enums.MealCategory.Dinner))
            {
                _food = FoodRepository.GetAll().Where(a => a.Id == food.FoodID).FirstOrDefault();
                gunlukKarbonhidrat += (_food.PortionCarb * food.Portion);
                gunlukProtein += (_food.PortionProtein * food.Portion);
                gunlukYag += (_food.PortionFat * food.Portion);
                gunlukKalori += (_food.PortionCalorie * food.Portion);
            }

            lblKarbonhidratAksamYemegi.Text = Math.Round(gunlukKarbonhidrat, 1).ToString() + " gr";
            lblProteinAksamYemegi.Text = Math.Round(gunlukProtein, 1).ToString() + " gr";
            lblYagAksamYemegi.Text = Math.Round(gunlukYag, 1).ToString() + " gr";
            lblKaloriAksamYemegi.Text = Math.Round(gunlukKalori, 1).ToString() + " cal";
        }

        private void ResetMealControls(string mealCategory)
        {
            switch (mealCategory)
            {
                case "Breakfast":
                    double gunlukKarbonhidrat = 0;
                    double gunlukProtein = 0;
                    double gunlukYag = 0;
                    double gunlukKalori = 0;
                    lblKarbonhidratKahvalti.Text = Math.Round(gunlukKarbonhidrat, 1).ToString() + " gr";
                    lblProteinKahvalti.Text = Math.Round(gunlukProtein, 1).ToString() + " gr";
                    lblYagKahvalti.Text = Math.Round(gunlukYag, 1).ToString() + " gr";
                    lblKaloriKahvalti.Text = Math.Round(gunlukKalori, 1).ToString() + " cal";
                    break;
                case "Lunch":
                    double gunlukKarbonhidrat2 = 0;
                    double gunlukProtein2 = 0;
                    double gunlukYag2 = 0;
                    double gunlukKalori2 = 0;
                    lblKarbonhidratOgleYemegi.Text = Math.Round(gunlukKarbonhidrat2, 1).ToString() + " gr";
                    lblProteinOgleYemegi.Text = Math.Round(gunlukProtein2, 1).ToString() + " gr";
                    lblYagOgleYemegi.Text = Math.Round(gunlukYag2, 1).ToString() + " gr";
                    lblKaloriOgleYemegi.Text = Math.Round(gunlukKalori2, 1).ToString() + " cal";
                    break;
                case "Dinner":
                    double gunlukKarbonhidrat3 = 0;
                    double gunlukProtein3 = 0;
                    double gunlukYag3 = 0;
                    double gunlukKalori3 = 0;
                    lblKarbonhidratAksamYemegi.Text = Math.Round(gunlukKarbonhidrat3, 1).ToString() + " gr";
                    lblProteinAksamYemegi.Text = Math.Round(gunlukProtein3, 1).ToString() + " gr";
                    lblYagAksamYemegi.Text = Math.Round(gunlukYag3, 1).ToString() + " gr";
                    lblKaloriAksamYemegi.Text = Math.Round(gunlukKalori3, 1).ToString() + " cal";
                    break;
            }
        }

        private void mainMenu_navBtn_Click(object sender, EventArgs e)
        {
            Navigations.GotoMainMenu(account, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Navigations.GotoLongReport(account, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Navigations.GotoSocial(account, this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Navigations.GotoExit(account, this);
        }

        private void lblProfileNameTop1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navigations.GotoProfile(account, this);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
