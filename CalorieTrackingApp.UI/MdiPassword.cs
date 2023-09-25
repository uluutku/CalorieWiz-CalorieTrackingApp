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
    public partial class MdiPassword : Form
    {
        public MdiPassword()
        {
            InitializeComponent();
        }

        private void MdiPassword_Load(object sender, EventArgs e)
        {

            EMailConfirmation eMailConfirmation = new EMailConfirmation();
            eMailConfirmation.MdiParent = this;
            this.Size = new Size(eMailConfirmation.Width, eMailConfirmation.Height);
            eMailConfirmation.FormBorderStyle = FormBorderStyle.None;
            eMailConfirmation.Dock = DockStyle.Fill;
            eMailConfirmation.Show();

        }


    }
}
