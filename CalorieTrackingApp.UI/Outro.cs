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
    public partial class Outro : Form
    {
        Form form;
        public Outro(Form _form)
        {
            form = _form;
            InitializeComponent();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {

            if (timer1.Interval == 1100)
            {
                timer1.Stop();
                form.Opacity = 0;
                form.Show();
                while (form.Opacity < 1)
                {
                    form.Opacity += 0.1;
                    await Task.Delay(50);
                }
                this.Close();
            }

            pbLogo.Visible = false;
            pictureBox2.BringToFront();
            pictureBox2.Visible = false;
            timer1.Interval = 1100;

        }

        private void Outro_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 4550;
        }
    }
}
