using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DATA.Entities;
using CalorieTrackingApp.UI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackingApp.UI
{
    public partial class LongReports : Form
    {
        Account _account;
        FoodRepository foodrep;
        ConsumedFoodRepository consumedFoodrep;
        ConsumedWaterRepository consumedWaterRep;
        WeightHistoryRepository weightHistoryRep;
        public LongReports(Account account)
        {
            _account = account;
            InitializeComponent();
        }

        private void LongReports_Load(object sender, EventArgs e)
        {
            BasicTools.TopDetailFiller(topBar_groupBox.Controls, _account.Id);
            dtpRapor.MaxDate = DateTime.Now.AddDays(-1);
            dtpRapor.MinDate = DateTime.Now.AddDays(-30);
            consumedFoodrep = new ConsumedFoodRepository();
            foodrep = new FoodRepository();
            consumedWaterRep = new ConsumedWaterRepository();
            weightHistoryRep = new WeightHistoryRepository();
            FoodGraph(30);
            WaterGraph(30);
            Weight(30);
        }
        private void btnShow_Click_1(object sender, EventArgs e)
        {
            TimeSpan difference = DateTime.Now - dtpRapor.Value;
            int day = Convert.ToInt32(difference.TotalDays);
            FoodGraph(day);
            WaterGraph(day);
            Weight(day);
        }


        public List<int> ConsumeFoodList(int day)
        {
            List<ConsumedFood> consumedFoods = consumedFoodrep.GetAll().Where(c => c.AccountID == _account.Id && c.ConsumedDate > (DateTime.Now.AddDays(-day))).OrderBy(c => c.ConsumedDate).ToList();
            List<Food> foods = foodrep.GetAll();
            if (consumedFoods.Count == 0) { return null; }
            int dayStoring = consumedFoods[0].ConsumedDate.Day;
            List<int> calories = new List<int>();
            calories.Add(0);
            int counter = 0;

            foreach (ConsumedFood cons in consumedFoods)
            {
                if (dayStoring != cons.ConsumedDate.Day)
                {
                    dayStoring = cons.ConsumedDate.Day;
                    counter++;
                    calories.Add(0);
                }
                calories[counter] += (int)Math.Floor(foods.First(f => f.Id == cons.FoodID).PortionCalorie) * cons.ConsumedCount;
            }
            return calories;
        }


        public void FoodGraph(int day)
        {
            ClearLabels(gbfoodGraph.Controls);
            List<int> calories = ConsumeFoodList(day);
            if (calories == null) { return; }
            int width = 40;
            int k = 1;
            foreach (int i in calories)
            {

                int targetNumb = i * 200 / 4000;

                Label label = new Label();
                label.Size = new Size(10, targetNumb);
                label.BackColor = Color.LightGreen;
                label.Location = new Point(width, 90 + (150 - targetNumb));
                label.BringToFront();
                gbfoodGraph.Controls.Add(label);

                Label label2 = new Label();
                label2.Text = k.ToString();
                label2.Size = new Size(30, 15);
                Font newFont = new Font("Arial", 10, FontStyle.Regular);
                label2.Font = newFont;
                label2.Location = new Point(width - 15, 250);
                label2.BringToFront();
                gbfoodGraph.Controls.Add(label2);
                width += 35;
                k++;
            }
            lbl2.SendToBack();
        }

        public List<int> ConsumeWaterList(int day)
        {
            List<ConsumedWater> consumedWater = consumedWaterRep.GetAll().Where(c => c.AccountID == _account.Id && c.ConsumedTime > (DateTime.Now.AddDays(-day))).OrderBy(c => c.ConsumedTime).ToList();
            if (consumedWater.Count == 0) { return null; }
            List<int> miliLiters = new List<int>();
            int dayStoring = consumedWater[0].ConsumedTime.Day;
            miliLiters.Add(0);
            int counter = 0;

            foreach (ConsumedWater cons in consumedWater)
            {
                if (dayStoring != cons.ConsumedTime.Day)
                {
                    dayStoring = cons.ConsumedTime.Day;
                    counter++;
                    miliLiters.Add(0);
                }
                miliLiters[counter] += (int)(cons.Portion * 1000.0);
            }
            return miliLiters;
        }

        public void WaterGraph(int day)
        {
            ClearLabels(gbWaterGraph.Controls);
            List<int> miliLiters = ConsumeWaterList(day);
            if (miliLiters == null) { return; }
            int width = 40;
            int k = 1;
            foreach (int i in miliLiters)
            {

                int targetNumb = i * 200 / 4000;

                Label label = new Label();
                label.Size = new Size(4, targetNumb);
                label.BackColor = Color.Blue;
                label.Location = new Point(width, 125 + (150 - targetNumb));
                label.BringToFront();
                gbWaterGraph.Controls.Add(label);

                Label label2 = new Label();
                label2.Text = k.ToString();
                label2.Size = new Size(17, 15);
                Font newFont = new Font("Arial", 6, FontStyle.Regular);
                label2.Font = newFont;
                label2.Location = new Point(width - 3, 277);
                label2.BringToFront();
                gbWaterGraph.Controls.Add(label2);
                width += 15;
                k++;
            }
            lbl4.SendToBack();
        }

        public List<int> WeightValues(int day)
        {
            List<WeightHistory> weightHistories = weightHistoryRep.GetAll().Where(c => c.AccountID == _account.Id && c.WeightDate > (DateTime.Now.AddDays(-day))).OrderBy(c => c.WeightDate).ToList();
            if (weightHistories.Count == 0) { return null; }
            List<int> kgs = new List<int>();
            int dayStoring = 100;

            foreach (WeightHistory cons in weightHistories)
            {
                if (dayStoring != cons.WeightDate.Day)
                {
                    dayStoring = cons.WeightDate.Day;
                    kgs.Add((int)cons.Weight);
                }
            }
            return kgs;
        }

        public void Weight(int day)
        {
            ClearLabels(gbWeight.Controls);
            List<int> kgs = WeightValues(day);
            if (kgs == null) { return; }
            int width = 42;
            int k = 1;
            foreach (int i in kgs)
            {

                int targetNumb = i * 200 / 200;

                Label label = new Label();
                label.Size = new Size(4, targetNumb);
                label.BackColor = Color.Gray;
                label.Location = new Point(width, 125 + (150 - targetNumb));
                label.BringToFront();
                gbWeight.Controls.Add(label);

                Label label2 = new Label();
                label2.Text = k.ToString();
                label2.Size = new Size(17, 15);
                Font newFont = new Font("Arial", 6, FontStyle.Regular);
                label2.Font = newFont;
                label2.Location = new Point(width - 3, 277);
                label2.BringToFront();
                gbWeight.Controls.Add(label2);
                width += 15;
                k++;
            }
            lbl6.SendToBack();
        }

        private void ClearLabels(Control.ControlCollection controls)
        {
            for (int i = 0; i < 5; i++)
            {
                foreach (Control control in controls)
                {

                    if (control is Label && control.Tag != "non")
                    {
                        controls.Remove(control);
                    }
                }
            }
            
        }

        private void exit_navbar_Click(object sender, EventArgs e)
        {
            Navigations.GotoExit(_account, this);
        }

        private void reports_navBtn_Click(object sender, EventArgs e)
        {
            Navigations.GotoDailyReport(_account, this);
        }

        private void social_navbar_Click(object sender, EventArgs e)
        {
            Navigations.GotoSocial(_account, this);
        }

        private void mainMenu_navBtn_Click(object sender, EventArgs e)
        {
            Navigations.GotoMainMenu(_account, this);
        }

        private void lblProfileNameTop1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navigations.GotoProfile(_account, this);

        }
    }
}
