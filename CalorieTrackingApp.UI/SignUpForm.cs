using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace CalorieTrackingApp.UI
{
    public partial class SignUpForm : Form
    {

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        public SignUpForm()
        {
            InitializeComponent();
        }

        AccountRepository accDb;
        SecurityQuestionRepository securityDb;
        private void SignUpForm_Load(object sender, EventArgs e)
        {
            txtSignUpPassword.UseSystemPasswordChar = true;
            txtSignUpPassRepeat.UseSystemPasswordChar = true;
            accDb = new AccountRepository();

            securityDb = new SecurityQuestionRepository();

            foreach (var item in securityDb.GetAll())
            {
                cmbPassQuestion.Items.Add(item.QestionText);
            }

        }

        private void UpdatePasswordStrength(string password)
        {
            int strength = 0;

            // Şifrenin en az 8 karakter içermesini kontrol et
            if (password.Length >= 8)
            {
                strength++;
            }
            else
            {
                strength = 0;
            }
            // Şifrede en az 1 büyük harf, 1 küçük harf ve 1 sayı olmasını kontrol et
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                strength++;
            }
            // Progress bar'ın değerini güncelle
            pbpassStr.Value = (strength * 50);

            switch (strength)
            {
                case 0:
                    PassStatus.Text = "Şifre Zayıf";
                    PassStatus.ForeColor = Color.Red;
                    break;
                case 1:
                    PassStatus.Text = "Şifre Orta";
                    PassStatus.ForeColor = Color.Blue;
                    break;
                case 2:
                    PassStatus.Text = "Şifre Güçlü";
                    PassStatus.ForeColor = Color.Green;
                    break;
                default:
                    PassStatus.Text = "";
                    break;
            }
        }

        Account account;
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string password = txtSignUpPassword.Text;
            string confirmPassword = txtSignUpPassRepeat.Text;

            if (password.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter ,1 büyük harf, 1 küçük harf ve 1 sayı içermelidir. içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (cmbPassQuestion.SelectedIndex < 0)
            {
                MessageBox.Show("Gizli soru seçip cevaplayınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (txtSignUpMail.Text.EndsWith("@gmail.com") || txtSignUpMail.Text.EndsWith("@hotmail.com") || txtSignUpMail.Text.EndsWith("@hotmail.com.tr") || txtSignUpMail.Text.EndsWith("@outlook.com") || txtSignUpMail.Text.EndsWith("@yandex.com"))
            {

                if (accDb.GetAll().FirstOrDefault(x => x.EMail.Contains(txtSignUpMail.Text)) != null)
                {
                    MessageBox.Show("Bu kullanıcı adı bulunmakta.Farklı bir ad ile kayıt olunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else
                {
                    if (txtSignUpPassword.Text != txtSignUpPassRepeat.Text)
                    {

                        MessageBox.Show("Parolalar birbiriyle eşleşmemektedir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;

                    }
                    else
                    {
                        RegisterMailCode registerMail = new RegisterMailCode(txtSignUpMail.Text);
                        DialogResult dr = registerMail.ShowDialog();
                        if (dr == DialogResult.OK)
                        {
                            string girilenSifre = txtSignUpPassword.Text;
                            string hashlenmisGirilenSifre = sha256_hash(girilenSifre);

                            account = new Account();
                            account.Name = txtSignUpName.Text;
                            account.Password = hashlenmisGirilenSifre;
                            account.EMail = txtSignUpMail.Text;
                            account.QuestionAnswer = txtSaveAnswer.Text;
                            account.SecurityQuestionId = securityDb.GetAll()[cmbPassQuestion.SelectedIndex].Id;
                            accDb.Add(account);


                            SignUpFillForm signUpFillForm = new SignUpFillForm(account);
                            this.Hide();
                            signUpFillForm.ShowDialog();
                            this.Close();
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("@gmail.com veya @hotmail.com formatında mail giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            // Hash fonskiyonu gelecek



        }

        private void SignUp_GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void SignUpPass_textBox_TextChanged(object sender, EventArgs e)
        {
            string password = txtSignUpPassword.Text;
            UpdatePasswordStrength(password);
        }

        private void SignUpPassRepeat_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lklblTurnBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pbpass_MouseDown(object sender, MouseEventArgs e)
        {
            txtSignUpPassword.UseSystemPasswordChar = false;
        }

        private void pbpass_MouseUp(object sender, MouseEventArgs e)
        {
            txtSignUpPassword.UseSystemPasswordChar = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtSignUpPassRepeat.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            txtSignUpPassRepeat.UseSystemPasswordChar = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
