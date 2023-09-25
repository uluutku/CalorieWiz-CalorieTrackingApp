namespace CalorieTrackingApp.UI
{
    partial class SignUpFillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpFillForm));
            button1 = new Button();
            label6 = new Label();
            dpBirthdate = new DateTimePicker();
            groupBox2 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            rbWoman = new RadioButton();
            rbMan = new RadioButton();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            cmbExercise = new ComboBox();
            label8 = new Label();
            btnSave = new Button();
            nudTargetWeight = new NumericUpDown();
            nudWeightEntry = new NumericUpDown();
            nudHeightEntry = new NumericUpDown();
            pbUserPhoto = new PictureBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTargetWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeightEntry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeightEntry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUserPhoto).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(488, 920);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(343, 75);
            button1.TabIndex = 38;
            button1.Text = "Kayıt Ol";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 535);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(223, 24);
            label6.TabIndex = 35;
            label6.Text = "Doğum Tarihinizi Girin:";
            // 
            // dpBirthdate
            // 
            dpBirthdate.Location = new Point(289, 529);
            dpBirthdate.Margin = new Padding(5);
            dpBirthdate.Name = "dpBirthdate";
            dpBirthdate.Size = new Size(219, 33);
            dpBirthdate.TabIndex = 34;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(rbWoman);
            groupBox2.Controls.Add(rbMan);
            groupBox2.Location = new Point(47, 400);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(430, 110);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cinsiyet";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(96, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(77, 77);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(286, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // rbWoman
            // 
            rbWoman.AutoSize = true;
            rbWoman.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbWoman.Location = new Point(271, 49);
            rbWoman.Margin = new Padding(5);
            rbWoman.Name = "rbWoman";
            rbWoman.Size = new Size(80, 24);
            rbWoman.TabIndex = 1;
            rbWoman.TabStop = true;
            rbWoman.Text = "Female";
            rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            rbMan.AutoSize = true;
            rbMan.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbMan.Location = new Point(79, 49);
            rbMan.Margin = new Padding(5);
            rbMan.Name = "rbMan";
            rbMan.Size = new Size(65, 24);
            rbMan.TabIndex = 0;
            rbMan.TabStop = true;
            rbMan.Text = "Male";
            rbMan.UseVisualStyleBackColor = true;
            rbMan.CheckedChanged += rbMan_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(117, 230);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(162, 24);
            label5.TabIndex = 32;
            label5.Text = "Boyunuzu Girin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 343);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(215, 24);
            label3.TabIndex = 30;
            label3.Text = "Hedef Kilonuzu Girin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 285);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(216, 24);
            label2.TabIndex = 28;
            label2.Text = "Şuanki Kilonuzu Girin:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(198, 170);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 26;
            label1.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(689, -54);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(216, 24);
            label4.TabIndex = 23;
            label4.Text = "Fiziksel Bilgierinizi Girin";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImage = Properties.Resources.output_onlinepngtools;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(pictureBox4);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(cmbExercise);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(nudTargetWeight);
            groupBox1.Controls.Add(nudWeightEntry);
            groupBox1.Controls.Add(nudHeightEntry);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dpBirthdate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pbUserPhoto);
            groupBox1.Location = new Point(632, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 798);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.goBackButton;
            pictureBox4.Location = new Point(89, 686);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 58;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.addPhoto;
            pictureBox1.Location = new Point(309, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cmbExercise
            // 
            cmbExercise.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbExercise.Location = new Point(289, 589);
            cmbExercise.Name = "cmbExercise";
            cmbExercise.Size = new Size(219, 32);
            cmbExercise.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 592);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(254, 24);
            label8.TabIndex = 40;
            label8.Text = "Hareket Seviyenizi Seçin:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(188, 682);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(189, 52);
            btnSave.TabIndex = 39;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nudTargetWeight
            // 
            nudTargetWeight.DecimalPlaces = 2;
            nudTargetWeight.Location = new Point(333, 341);
            nudTargetWeight.Margin = new Padding(9, 8, 9, 8);
            nudTargetWeight.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudTargetWeight.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            nudTargetWeight.Name = "nudTargetWeight";
            nudTargetWeight.Size = new Size(120, 33);
            nudTargetWeight.TabIndex = 38;
            nudTargetWeight.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // nudWeightEntry
            // 
            nudWeightEntry.DecimalPlaces = 2;
            nudWeightEntry.Location = new Point(333, 283);
            nudWeightEntry.Margin = new Padding(9, 8, 9, 8);
            nudWeightEntry.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            nudWeightEntry.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            nudWeightEntry.Name = "nudWeightEntry";
            nudWeightEntry.Size = new Size(120, 33);
            nudWeightEntry.TabIndex = 37;
            nudWeightEntry.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // nudHeightEntry
            // 
            nudHeightEntry.DecimalPlaces = 2;
            nudHeightEntry.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudHeightEntry.Location = new Point(333, 228);
            nudHeightEntry.Margin = new Padding(5);
            nudHeightEntry.Maximum = new decimal(new int[] { 25, 0, 0, 65536 });
            nudHeightEntry.Minimum = new decimal(new int[] { 12, 0, 0, 65536 });
            nudHeightEntry.Name = "nudHeightEntry";
            nudHeightEntry.Size = new Size(120, 33);
            nudHeightEntry.TabIndex = 36;
            nudHeightEntry.Value = new decimal(new int[] { 12, 0, 0, 65536 });
            // 
            // pbUserPhoto
            // 
            pbUserPhoto.Image = Properties.Resources.defaultMale;
            pbUserPhoto.Location = new Point(205, 34);
            pbUserPhoto.Margin = new Padding(5);
            pbUserPhoto.Name = "pbUserPhoto";
            pbUserPhoto.Size = new Size(126, 122);
            pbUserPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserPhoto.TabIndex = 24;
            pbUserPhoto.TabStop = false;
            // 
            // SignUpFillForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bacgroundv1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1194, 835);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "SignUpFillForm";
            Text = "Kullanıcı Detayları";
            FormClosing += SignUpFillForm_FormClosing;
            Load += SignUpFillForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTargetWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeightEntry).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeightEntry).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUserPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label6;
        private DateTimePicker dpBirthdate;
        private GroupBox groupBox2;
        private RadioButton rbWoman;
        private RadioButton rbMan;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private GroupBox groupBox1;
        private PictureBox pbUserPhoto;
        private NumericUpDown nudHeightEntry;
        private Button btnSave;
        private NumericUpDown nudTargetWeight;
        private NumericUpDown nudWeightEntry;
        private ComboBox cmbExercise;
        private Label label8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}