namespace CalorieTrackingApp.UI
{
    partial class Outro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Outro));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.witch_hat;
            pictureBox2.Location = new Point(889, 437);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.giphy;
            pictureBox1.Location = new Point(204, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(636, 636);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(611, 459);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(272, 65);
            pbLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            pbLogo.TabIndex = 18;
            pbLogo.TabStop = false;
            // 
            // Outro
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
            Name = "Outro";
            Text = "Outro";
            Load += Outro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pbLogo;
    }
}