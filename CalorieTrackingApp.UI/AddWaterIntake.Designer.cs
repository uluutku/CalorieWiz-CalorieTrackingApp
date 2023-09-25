namespace CalorieTrackingApp.UI
{
    partial class AddWaterIntake
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox6 = new PictureBox();
            groupBox2 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnRemove = new Button();
            btnKaydet = new Button();
            label4 = new Label();
            nudAlinanSu = new NumericUpDown();
            label3 = new Label();
            rb1000 = new RadioButton();
            rb500 = new RadioButton();
            rb250 = new RadioButton();
            groupBox6 = new GroupBox();
            pictureBox7 = new PictureBox();
            pictureBox5 = new PictureBox();
            lblGunlukSuIcilen = new Label();
            label6 = new Label();
            lblYuzdeSu = new Label();
            label43 = new Label();
            lblGunlukSuHedefKalan = new Label();
            label41 = new Label();
            lblGunlukSuHedef = new Label();
            label39 = new Label();
            waterIntake_progressBar = new ProgressBar();
            label1 = new Label();
            dtpDate = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAlinanSu).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(pictureBox6);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Location = new Point(12, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(578, 811);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.date;
            pictureBox1.Location = new Point(81, 203);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Enabled = false;
            pictureBox6.Image = Properties.Resources.waterIntakeIcon;
            pictureBox6.Location = new Point(237, 32);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(105, 101);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 51;
            pictureBox6.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(btnRemove);
            groupBox2.Controls.Add(btnKaydet);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(nudAlinanSu);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(rb1000);
            groupBox2.Controls.Add(rb500);
            groupBox2.Controls.Add(rb250);
            groupBox2.Location = new Point(15, 533);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(557, 272);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Su Alımı Ekle";
            // 
            // pictureBox4
            // 
            pictureBox4.Enabled = false;
            pictureBox4.Image = Properties.Resources.bigBottleWater;
            pictureBox4.Location = new Point(413, 51);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 55;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Enabled = false;
            pictureBox3.Image = Properties.Resources.bottleWater;
            pictureBox3.Location = new Point(252, 49);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 54;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Enabled = false;
            pictureBox2.Image = Properties.Resources.glassWater;
            pictureBox2.Location = new Point(79, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 53;
            pictureBox2.TabStop = false;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(33, 198);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(146, 39);
            btnRemove.TabIndex = 49;
            btnRemove.Text = "Sil";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(389, 198);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(146, 39);
            btnKaydet.TabIndex = 48;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 208);
            label4.Name = "label4";
            label4.Size = new Size(20, 24);
            label4.TabIndex = 47;
            label4.Text = "L";
            // 
            // nudAlinanSu
            // 
            nudAlinanSu.DecimalPlaces = 2;
            nudAlinanSu.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            nudAlinanSu.Location = new Point(211, 202);
            nudAlinanSu.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudAlinanSu.Name = "nudAlinanSu";
            nudAlinanSu.Size = new Size(120, 33);
            nudAlinanSu.TabIndex = 46;
            nudAlinanSu.ValueChanged += nudAlinanSu_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(253, 165);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 45;
            label3.Text = "Veya";
            // 
            // rb1000
            // 
            rb1000.AutoSize = true;
            rb1000.Location = new Point(413, 113);
            rb1000.Name = "rb1000";
            rb1000.Size = new Size(57, 28);
            rb1000.TabIndex = 2;
            rb1000.TabStop = true;
            rb1000.Text = "1Lt";
            rb1000.UseVisualStyleBackColor = true;
            // 
            // rb500
            // 
            rb500.AutoSize = true;
            rb500.Location = new Point(236, 113);
            rb500.Name = "rb500";
            rb500.Size = new Size(90, 28);
            rb500.TabIndex = 1;
            rb500.TabStop = true;
            rb500.Text = "500ml";
            rb500.UseVisualStyleBackColor = true;
            // 
            // rb250
            // 
            rb250.AutoSize = true;
            rb250.Location = new Point(62, 112);
            rb250.Name = "rb250";
            rb250.Size = new Size(90, 28);
            rb250.TabIndex = 0;
            rb250.TabStop = true;
            rb250.Text = "250ml";
            rb250.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(pictureBox7);
            groupBox6.Controls.Add(pictureBox5);
            groupBox6.Controls.Add(lblGunlukSuIcilen);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(lblYuzdeSu);
            groupBox6.Controls.Add(label43);
            groupBox6.Controls.Add(lblGunlukSuHedefKalan);
            groupBox6.Controls.Add(label41);
            groupBox6.Controls.Add(lblGunlukSuHedef);
            groupBox6.Controls.Add(label39);
            groupBox6.Controls.Add(waterIntake_progressBar);
            groupBox6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(6, 295);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(557, 232);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Su Alım İstatistikleri";
            // 
            // pictureBox7
            // 
            pictureBox7.Enabled = false;
            pictureBox7.Image = Properties.Resources.waterDone;
            pictureBox7.Location = new Point(23, 96);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(32, 30);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 54;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Enabled = false;
            pictureBox5.Image = Properties.Resources.target;
            pictureBox5.Location = new Point(386, 98);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 53;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // lblGunlukSuIcilen
            // 
            lblGunlukSuIcilen.AutoSize = true;
            lblGunlukSuIcilen.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblGunlukSuIcilen.Location = new Point(108, 99);
            lblGunlukSuIcilen.Name = "lblGunlukSuIcilen";
            lblGunlukSuIcilen.Size = new Size(66, 28);
            lblGunlukSuIcilen.TabIndex = 49;
            lblGunlukSuIcilen.Text = "2.2LT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(52, 103);
            label6.Name = "label6";
            label6.Size = new Size(62, 22);
            label6.TabIndex = 48;
            label6.Text = "İçilen:";
            // 
            // lblYuzdeSu
            // 
            lblYuzdeSu.AutoSize = true;
            lblYuzdeSu.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblYuzdeSu.Location = new Point(248, 188);
            lblYuzdeSu.Name = "lblYuzdeSu";
            lblYuzdeSu.Size = new Size(46, 28);
            lblYuzdeSu.TabIndex = 47;
            lblYuzdeSu.Text = "%0";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(403, 45);
            label43.Name = "label43";
            label43.Size = new Size(124, 21);
            label43.TabIndex = 46;
            label43.Text = "daha içmelisin.";
            // 
            // lblGunlukSuHedefKalan
            // 
            lblGunlukSuHedefKalan.AutoSize = true;
            lblGunlukSuHedefKalan.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblGunlukSuHedefKalan.Location = new Point(324, 42);
            lblGunlukSuHedefKalan.Name = "lblGunlukSuHedefKalan";
            lblGunlukSuHedefKalan.Size = new Size(66, 28);
            lblGunlukSuHedefKalan.TabIndex = 45;
            lblGunlukSuHedefKalan.Text = "2.2LT";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(44, 44);
            label41.Name = "label41";
            label41.Size = new Size(269, 21);
            label41.TabIndex = 44;
            label41.Text = "Bugünkü su hedefine ulaşmak için";
            // 
            // lblGunlukSuHedef
            // 
            lblGunlukSuHedef.AutoSize = true;
            lblGunlukSuHedef.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblGunlukSuHedef.Location = new Point(478, 101);
            lblGunlukSuHedef.Name = "lblGunlukSuHedef";
            lblGunlukSuHedef.Size = new Size(66, 28);
            lblGunlukSuHedef.TabIndex = 43;
            lblGunlukSuHedef.Text = "2.2LT";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label39.Location = new Point(415, 105);
            label39.Name = "label39";
            label39.Size = new Size(71, 22);
            label39.TabIndex = 31;
            label39.Text = "Hedef:";
            // 
            // waterIntake_progressBar
            // 
            waterIntake_progressBar.Location = new Point(23, 133);
            waterIntake_progressBar.Name = "waterIntake_progressBar";
            waterIntake_progressBar.Size = new Size(521, 50);
            waterIntake_progressBar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(167, 151);
            label1.Name = "label1";
            label1.Size = new Size(252, 39);
            label1.TabIndex = 7;
            label1.Text = "Su Alımı Kaydet";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(149, 214);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(356, 33);
            dtpDate.TabIndex = 6;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // AddWaterIntake
            // 
            AcceptButton = btnKaydet;
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 829);
            Controls.Add(groupBox1);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "AddWaterIntake";
            Text = "Su Ekleme Ekranı";
            Load += AddWaterIntake_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAlinanSu).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker dtpDate;
        private GroupBox groupBox6;
        private Label lblYuzdeSu;
        private Label label43;
        private Label lblGunlukSuHedefKalan;
        private Label label41;
        private Label lblGunlukSuHedef;
        private Label label39;
        private ProgressBar waterIntake_progressBar;
        private GroupBox groupBox2;
        private Button btnKaydet;
        private Label label4;
        private NumericUpDown nudAlinanSu;
        private Label label3;
        private RadioButton rb1000;
        private RadioButton rb500;
        private RadioButton rb250;
        private Label lblGunlukSuIcilen;
        private Label label6;
        private Button btnRemove;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
    }
}