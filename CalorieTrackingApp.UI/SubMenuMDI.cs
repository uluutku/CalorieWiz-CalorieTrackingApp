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
    public partial class SubMenuMDI : Form
    {
        Account _account;
        public SubMenuMDI(Account account)
        {
            _account = account;
            InitializeComponent();
        }

        private void SubMenuMDI_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            MainMenu mainMenu = new MainMenu(_account);
            mainMenu.MdiParent = this;
            this.Size = new Size(mainMenu.Width, mainMenu.Height);
            mainMenu.FormBorderStyle = FormBorderStyle.None;
            mainMenu.Dock = DockStyle.Fill;
            mainMenu.Show();
        }

    }
}
