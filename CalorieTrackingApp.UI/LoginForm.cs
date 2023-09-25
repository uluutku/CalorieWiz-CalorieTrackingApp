using CalorieTrackingApp.BLL.Repositories;
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
using System.Security.Cryptography;

namespace CalorieTrackingApp.UI
{
    public partial class LoginForm : Form
    {

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {

                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }


        public LoginForm()
        {
            InitializeComponent();
        }

        private void lklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm sign = new SignUpForm();
            this.Hide();
            sign.ShowDialog();
            this.Show();

        }

        Account account;
        private void btnEntry_Click(object sender, EventArgs e)
        {

            string girilenSifre = txtLoginPassword.Text;
            string hashlenmisGirilenSifre = sha256_hash(girilenSifre);
            accountRepository = new AccountRepository();
            foreach (Account item in accountRepository.GetAll())
            {
                if (item.EMail == txtLoginUsername.Text && item.Password == hashlenmisGirilenSifre)
                {

                    item.DateOfEntry = DateTime.Now;
                    accountRepository.Update(item);
                    account = item; // giriş yapılan accountu çekiyoruz.
                    if (chkRememberMe.Checked)
                    {
                        using (StreamWriter sw = new StreamWriter(rememberMe)) // beni hatırla chk tıklanmışsa 0 arka plana yazdırılacak
                        {
                            sw.Write(0);
                        };
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(rememberMe)) // beni hatırla chk tıklanmamışsa 1 arka plana yazdırılacak
                        {
                            sw.Write(1);
                        };
                    }

                    SubMenuMDI mainMenu = new SubMenuMDI(account);
                    this.Hide();
                    mainMenu.ShowDialog();
                    this.Show();
                    return;
                }
                else if (incomingValue == "0")
                {
                    if (item.EMail == txtLoginUsername.Text && txtLoginPassword.Text == item.Password)
                    {
                        item.DateOfEntry = DateTime.Now;
                        accountRepository.Update(item);
                        account = item; // giriş yapılan accountu çekiyoruz.
                        if (chkRememberMe.Checked)
                        {
                            using (StreamWriter sw = new StreamWriter(rememberMe)) // beni hatırla chk tıklanmışsa 0 arka plana yazdırılacak
                            {
                                sw.Write(0);
                            };
                        }
                        else
                        {
                            using (StreamWriter sw = new StreamWriter(rememberMe)) // beni hatırla chk tıklanmamışsa 1 arka plana yazdırılacak
                            {
                                sw.Write(1);
                            };
                        }

                        SubMenuMDI mainMenu = new SubMenuMDI(account);
                        this.Hide();
                        mainMenu.ShowDialog();
                        this.Show();
                        return;
                    }

                }


            }

            MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
        AccountRepository accountRepository;
        string rememberMe;
        string incomingValue;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            Intro1 intro = new Intro1(this);
            intro.ShowDialog();
            accountRepository = new AccountRepository();
            txtLoginPassword.UseSystemPasswordChar = true;
            rememberMe = Path.Combine(Application.StartupPath, "BeniHatirla.txt");

            File.AppendAllText(rememberMe, "");

            using (StreamReader reader = new StreamReader(rememberMe))
            {


                incomingValue = reader.ReadToEnd();

                if (incomingValue == "0")
                {

                    Account lastLogin = accountRepository.GetAll().OrderByDescending(x => x.DateOfEntry).FirstOrDefault();
                    txtLoginPassword.Text = lastLogin.Password.ToString();
                    txtLoginUsername.Text = lastLogin.EMail.ToString();
                    chkRememberMe.Checked = true;

                }

            };

            if (chkRememberMe.Checked)
            {
                pbpass.Visible = false;
                txtLoginPassword.UseSystemPasswordChar = true;
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MdiPassword passwordReset = new MdiPassword();
            this.Hide();
            passwordReset.ShowDialog();
            this.Show();



        }

        private void txtLoginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkRememberMe.Checked)
            {
                pbpass.Visible = true;
                txtLoginPassword.Text = "";
                txtLoginUsername.Text = "";
            }
        }

        private void pbpass_MouseDown(object sender, MouseEventArgs e)
        {
            txtLoginPassword.UseSystemPasswordChar = false;
        }

        private void pbpass_MouseUp(object sender, MouseEventArgs e)
        {
            txtLoginPassword.UseSystemPasswordChar = true;
        }

        private void btnEntry_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_Enter(object sender, EventArgs e)
        {
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Outro outro = new Outro(this);
            outro.ShowDialog();
        }

    }


}
