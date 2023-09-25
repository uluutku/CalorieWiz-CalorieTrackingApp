using CalorieTrackingApp.BLL.Repositories;
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

namespace CalorieTrackingApp.UI
{
    public partial class SignPassword : Form
    {
        public SignPassword()
        {
            InitializeComponent();
        }

        public SignPassword(Account _account)
        {
            account = _account;
            InitializeComponent();
        }

        Account account;
        AccountRepository accountRepository;
        private void SignPassword_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(254, 200, 77);
            accountRepository = new AccountRepository();

        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {

                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void btnPassReset_Click(object sender, EventArgs e)
        {

            if (txtSignUpPass1.Text.Length < 8 || lblPassStatus.Text != "Şifre Güçlü")
            {
                MessageBox.Show("Şifre en az 8 karakter ,1 büyük harf, 1 küçük harf ve 1 sayı içermelidir. içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtSignUpPass1.Text != txtSignUpPassRepeat.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                string sifre = sha256_hash(txtSignUpPass1.Text);
                account.Password = sifre;
                accountRepository.Update(account);
                MessageBox.Show("Şifre Başarıyla Güncellendi!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                (MdiParent as MdiPassword).Close();
            }


        }

        private void txtSignUpPass1_TextChanged(object sender, EventArgs e)
        {
            string password = txtSignUpPass1.Text;
            UpdatePasswordStrength(password);

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
            prbPassStr.Value = (strength * 50);

            switch (strength)
            {
                case 0:
                    lblPassStatus.Text = "Şifre Zayıf";
                    lblPassStatus.ForeColor = Color.Red;
                    break;
                case 1:
                    lblPassStatus.Text = "Şifre Orta";
                    lblPassStatus.ForeColor = Color.Blue;
                    break;
                case 2:
                    lblPassStatus.Text = "Şifre Güçlü";
                    lblPassStatus.ForeColor = Color.Green;
                    break;
                default:
                    lblPassStatus.Text = "";
                    break;
            }
        }

    }
}
