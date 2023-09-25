using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackingApp.UI
{
    public partial class PPasswordChange : Form
    {
        AccountRepository accounts;
        Account _account;
        public PPasswordChange(Account account)
        {
            _account = account;
            InitializeComponent();
        }

        private void PPasswordChange_Load(object sender, EventArgs e)
        {
            accounts = new AccountRepository();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string psswordFromDb = _account.Password;
            string password = txtPass.Text;
            string hashlenmisGirilenSifre = sha256_hash(password);
            string newPassword = txtNewPass.Text;
            string newPassword2 = txtNewPass2.Text;

            if (hashlenmisGirilenSifre != psswordFromDb)
            {
                MessageBox.Show("Şifreniz yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (IsStrongPassword(newPassword))
            {
                MessageBox.Show("Şifre en az 8 karakter ,1 büyük harf, 1 küçük harf ve 1 sayı içermelidir. içermelidir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (newPassword != newPassword2)
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Şifresiz başarılı bir şekilde değiştirilmiştir.", "Başarılı", MessageBoxButtons.OK);

                this.Close();
            }

        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {

                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }

        }

        private bool IsStrongPassword(string password)
        {
            if (password.Length < 8)
            {
                return true;
            }
            if (!password.Any(char.IsUpper))
            {
                return true;
            }
            if (!password.Any(char.IsLower))
            {
                return true;
            }
            if (!password.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Şifre değiştirme ekranından çıkmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void pbpass_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void pbpass_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void pbNewPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = false;
        }

        private void pbNewPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = true;
        }

        private void pbNewPass2_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewPass2.UseSystemPasswordChar = false;
        }

        private void pbNewPass2_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPass2.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
