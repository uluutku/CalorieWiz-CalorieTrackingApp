using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackingApp.UI
{
    public partial class AddWeightData : Form
    {
        private Account account;


        public AddWeightData(Account account)
        {
            this.account = account;
            InitializeComponent();
        }

        WeightHistoryRepository WeightHistoryRepository;
        WeightHistory weightHistory;


        private void AddWeightData_Load(object sender, EventArgs e)
        {
            dtpDate.MaxDate = DateTime.Now;
            WeightHistoryRepository = new WeightHistoryRepository();
            WeightStatistic(); //Labelları ve diğer parçaları doldurma.
        }

        UserDetail userDetail;
        UserDetailRepository userDetails;
        private void WeightStatistic()
        {
            userDetail = new UserDetail();
            userDetails = new UserDetailRepository();
            userDetail = userDetails.GetAll().Where(u => u.AccountId == account.Id).FirstOrDefault();


            //dtpDate.Value = DateTime.Now;
            weightHistory = WeightHistoryRepository.GetAll().First(a => a.AccountID == account.Id && a.WeightDate.Day == account.RegisterDate.Day && a.WeightDate.Month == account.RegisterDate.Month);  //Kayıt Olurken Girilen Kilo Çekildi
            double baslangicKilo = weightHistory.Weight;


            lblBaslangicKilo.Text = baslangicKilo.ToString();
            lblDegisenKilo.Text = Math.Abs(baslangicKilo - userDetail.LastWeight).ToString();

            if (baslangicKilo > userDetail.LastWeight)
            {
                lblDegisenKilo2.Text = "kg verdin.";
            }
            else if (userDetail.LastWeight > baslangicKilo)
            {
                lblDegisenKilo2.Text = "kg aldın.";
            }
            else
            {
                lblDegisenKilo.Text = "-";
                lblDegisenKilo2.Text = "kg değişmedi.";
            }

            lblHedefeKalanKilo.Text = Math.Abs(userDetail.TargetWeight - userDetail.LastWeight).ToString();
            if (baslangicKilo > userDetail.TargetWeight && userDetail.LastWeight < userDetail.TargetWeight)
            {
                lblHedefeKalanKilo2.Text = "kg daha vermelisin.";
            }
            else if (userDetail.TargetWeight > baslangicKilo && userDetail.LastWeight > userDetail.TargetWeight)
            {
                lblHedefeKalanKilo2.Text = "kg daha almalısın.";
            }


            nudGuncelKilo.Value = (decimal)userDetail.LastWeight;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            #region Yeni Kilo Ekleme

            if (nudGuncelKilo.Value == (decimal)userDetail.LastWeight)
            {
                MessageBox.Show($"Güncel Kilonuz Zaten {userDetail.LastWeight}'tir.");
                return;
            }

            weightHistory = new WeightHistory()
            {
                Weight = (double)nudGuncelKilo.Value,
                WeightDate = dtpDate.Value,
                AccountID = account.Id
            };

            WeightHistoryRepository.Add(weightHistory);
            #endregion

            #region Kiloyu Güncelleme
            userDetail.LastWeight = (double)nudGuncelKilo.Value;
            userDetails.Update(userDetail);
            #endregion


            WeightStatistic(); //Labelları ve diğer parçaları doldurma.


        }
    }
}
