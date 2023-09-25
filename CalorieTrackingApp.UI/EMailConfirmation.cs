using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackingApp.UI
{
    public partial class EMailConfirmation : Form
    {
        public EMailConfirmation()
        {
            InitializeComponent();
        }


        AccountRepository accountRepository;
        SecurityQuestionRepository securityQuestionRepository;
        Account account;
        private void EMailConfirmation_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(254, 200, 77);
            accountRepository = new AccountRepository();
            securityQuestionRepository = new SecurityQuestionRepository();
            btnMail.Enabled = true;

        }

        SecurityQuestion security;
        private void btnMail_Click(object sender, EventArgs e)
        {

            foreach (Account item in accountRepository.GetAll())
            {
                if (item.EMail == txtMail.Text)
                {

                    account = item;
                    lblUserName.Text = item.Name;
                    security = securityQuestionRepository.GetAll().FirstOrDefault(x => x.Id == account.SecurityQuestionId);
                    lblSecretQuestion.Text = security.QestionText;
                    btnMail.Enabled = false;

                    (MdiParent as MdiPassword).Size = new Size(570, 620);

                }
            }

            if (account == null)
            {
                MessageBox.Show("Bu mail adresinde kullanıcı bulunmamaktadır.! \nTekrar deneyiniz", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }
        DialogResult dr;
        private void btnQuestion_Click(object sender, EventArgs e)
        {
            if (account.QuestionAnswer == txtAnswer.Text)
            {

                SendCodeMail sendCodeMail = new SendCodeMail(account);
                sendCodeMail.MdiParent = (MdiParent as MdiPassword);
                (MdiParent as MdiPassword).Size = new Size(sendCodeMail.Width, sendCodeMail.Height);
                sendCodeMail.FormBorderStyle = FormBorderStyle.None;
                sendCodeMail.Dock = DockStyle.Fill;
                sendCodeMail.Show();
                this.Close();

            }
            else
            {

                MessageBox.Show("Cevap Doğrulanamadı.\nTekrar Giriniz!");
            }



        }
        private void MdiChildOpen()
        {


        }
    }
}
