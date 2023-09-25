namespace CalorieTrackingApp.UI
{
    partial class Intro1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.giphy;
            pictureBox1.Location = new Point(286, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(636, 636);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.witch_hat;
            pictureBox2.Location = new Point(970, 423);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(695, 441);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(272, 65);
            pbLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            pbLogo.TabIndex = 15;
            pbLogo.TabStop = false;
            pbLogo.Visible = false;
            // 
            // Intro1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1208, 792);
            ControlBox = false;
            Controls.Add(pbLogo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Intro1";
            Text = "Into";
            Load += Intro1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pbLogo;
    }
}