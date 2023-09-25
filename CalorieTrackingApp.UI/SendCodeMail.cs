using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalorieTrackingApp.DATA.Entities;

namespace CalorieTrackingApp.UI
{
    public partial class SendCodeMail : Form
    {
        public SendCodeMail()
        {
            InitializeComponent();
        }

        Account account;
        public SendCodeMail(Account _account)
        {

            account = _account;
            InitializeComponent();
        }

        Random random;
        string code;
        int second;
        private void SendCodeMail_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(254, 200, 77);
            pictureBox1.BackColor = Color.FromArgb(254, 200, 77);
            random = new Random();
            second = 60;
            btnConfirmation.Enabled = false;

            for (int i = 0; i < 5; i++)
            {
                code += Convert.ToString(random.Next(0, 10));

            }

        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {

            if (txtCode.Text == code)
            {

                SignPassword signPass = new SignPassword(account);
                signPass.MdiParent = (MdiParent as MdiPassword);
                (MdiParent as MdiPassword).Size = new Size(signPass.Width, signPass.Height);
                signPass.FormBorderStyle = FormBorderStyle.None;
                signPass.Dock = DockStyle.Fill;
                signPass.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Yanlış Kod Tekrar Deneyiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second -= 1;
            lblSecond.Text = (second).ToString();

            if (second <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Zamanınız Doldu! Tekrar Gönderiniz");
                btnSend.Enabled = true;
                btnConfirmation.Enabled = false;
                second = 60;
                lblSecond.BackColor = SystemColors.Control;
                lblSecond.Text = (second).ToString();
            }
            else if (second == 60)
            {
                lblSecond.ForeColor = Color.Red;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (MdiParent as MdiPassword).Close();
        }



        private void SendCode()
        {
            try
            {
                label4.Text = code;
                string smtpServer = "smtp.office365.com"; //SMTP sunucusu adresi
                int port = 587; //SMTP sunucusu port numarası
                string senderEmail = "caloriewiz@hotmail.com"; //Gönderen e-posta adresi
                string password = "Calorie01"; //Gönderen e-posta hesabının şifresi
                string recipientEmail = account.EMail.Trim(); //Alıcı e-posta adresi

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(recipientEmail);
                mail.Subject = "CalorieWiz Hesap Doğrulama"; //E-posta konusu

                // E-posta içeriği HTML formatında
                mail.IsBodyHtml = true;
                mail.Body = @"<!DOCTYPE html>
                        <html lang='tr'>
                        <head>
                            <meta charset='UTF-8'>
                            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                            <title>Hesap Doğrulama</title>
                        </head>
                        <body style='font-family: Arial, sans-serif;'>
                            <h2 style='color: #333;'>CalorieWiz Hesap Doğrulama</h2>
                            <p style='color: #666;'>Merhaba,</p>
                            <p style='color: #666;'>CalorieWiz hesabınızı doğrulamak için aşağıdaki doğrulama kodunu kullanın:</p>
                            <p style='background-color: #f4f4f4; padding: 10px; font-size: 20px; border: 1px solid #ddd; display: inline-block;'>" + code + @"</p>
                            <p style='color: #666;'>Bu kod sadece 1 dakika boyunca geçerlidir.</p>
                            <p style='color: #666;'>İyi günler dileriz.</p>
                        </body>
                        </html>";

                SmtpClient smtpClient = new SmtpClient(smtpServer, port);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(senderEmail, password);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("E-posta gönderirken bir hata oluştu: " + ex.Message);
            }
        }


        private void btnSend_Click(object sender, EventArgs e)
        {

            SendCode();
            timer1.Start();
            btnSend.Enabled = false;
            btnConfirmation.Enabled = true;

        }



        private void label2_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
        }
    }
}
