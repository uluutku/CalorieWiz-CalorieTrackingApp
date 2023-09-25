namespace CalorieTrackingApp.UI
{
    partial class SignUpForm
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
            SignUp_GroupBox = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pbpass = new PictureBox();
            PassStatus = new Label();
            pbpassStr = new ProgressBar();
            btn_SignUp = new Button();
            txtSaveAnswer = new TextBox();
            label6 = new Label();
            label5 = new Label();
            cmbPassQuestion = new ComboBox();
            txtSignUpName = new TextBox();
            label4 = new Label();
            txtSignUpPassRepeat = new TextBox();
            label3 = new Label();
            txtSignUpPassword = new TextBox();
            label2 = new Label();
            txtSignUpMail = new TextBox();
            label1 = new Label();
            SignUp_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpass).BeginInit();
            SuspendLayout();
            // 
            // SignUp_GroupBox
            // 
            SignUp_GroupBox.BackColor = Color.Transparent;
            SignUp_GroupBox.BackgroundImage = Properties.Resources.output_onlinepngtools;
            SignUp_GroupBox.BackgroundImageLayout = ImageLayout.Stretch;
            SignUp_GroupBox.Controls.Add(pictureBox2);
            SignUp_GroupBox.Controls.Add(pictureBox1);
            SignUp_GroupBox.Controls.Add(pbpass);
            SignUp_GroupBox.Controls.Add(PassStatus);
            SignUp_GroupBox.Controls.Add(pbpassStr);
            SignUp_GroupBox.Controls.Add(btn_SignUp);
            SignUp_GroupBox.Controls.Add(txtSaveAnswer);
            SignUp_GroupBox.Controls.Add(label6);
            SignUp_GroupBox.Controls.Add(label5);
            SignUp_GroupBox.Controls.Add(cmbPassQuestion);
            SignUp_GroupBox.Controls.Add(txtSignUpName);
            SignUp_GroupBox.Controls.Add(label4);
            SignUp_GroupBox.Controls.Add(txtSignUpPassRepeat);
            SignUp_GroupBox.Controls.Add(label3);
            SignUp_GroupBox.Controls.Add(txtSignUpPassword);
            SignUp_GroupBox.Controls.Add(label2);
            SignUp_GroupBox.Controls.Add(txtSignUpMail);
            SignUp_GroupBox.Controls.Add(label1);
            SignUp_GroupBox.Location = new Point(715, 27);
            SignUp_GroupBox.Name = "SignUp_GroupBox";
            SignUp_GroupBox.Size = new Size(482, 670);
            SignUp_GroupBox.TabIndex = 0;
            SignUp_GroupBox.TabStop = false;
            SignUp_GroupBox.Enter += SignUp_GroupBox_Enter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.goBackButton;
            pictureBox2.Location = new Point(60, 592);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 57;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.eye;
            pictureBox1.Location = new Point(413, 316);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // pbpass
            // 
            pbpass.BackColor = Color.White;
            pbpass.BackgroundImageLayout = ImageLayout.None;
            pbpass.Image = Properties.Resources.eye;
            pbpass.Location = new Point(412, 239);
            pbpass.Margin = new Padding(3, 2, 3, 2);
            pbpass.Name = "pbpass";
            pbpass.Size = new Size(28, 28);
            pbpass.SizeMode = PictureBoxSizeMode.StretchImage;
            pbpass.TabIndex = 15;
            pbpass.TabStop = false;
            pbpass.MouseDown += pbpass_MouseDown;
            pbpass.MouseUp += pbpass_MouseUp;
            // 
            // PassStatus
            // 
            PassStatus.AutoSize = true;
            PassStatus.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PassStatus.Location = new Point(46, 388);
            PassStatus.Name = "PassStatus";
            PassStatus.Size = new Size(14, 20);
            PassStatus.TabIndex = 14;
            PassStatus.Text = "-";
            // 
            // pbpassStr
            // 
            pbpassStr.Location = new Point(45, 362);
            pbpassStr.Name = "pbpassStr";
            pbpassStr.Size = new Size(400, 18);
            pbpassStr.TabIndex = 13;
            // 
            // btn_SignUp
            // 
            btn_SignUp.Location = new Point(160, 592);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(194, 48);
            btn_SignUp.TabIndex = 7;
            btn_SignUp.Text = "Kayıt Ol";
            btn_SignUp.UseVisualStyleBackColor = true;
            btn_SignUp.Click += btn_SignUp_Click;
            // 
            // txtSaveAnswer
            // 
            txtSaveAnswer.Location = new Point(45, 530);
            txtSaveAnswer.Name = "txtSaveAnswer";
            txtSaveAnswer.Size = new Size(401, 33);
            txtSaveAnswer.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 497);
            label6.Name = "label6";
            label6.Size = new Size(185, 24);
            label6.TabIndex = 10;
            label6.Text = "Gizli Soru Cevabı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 418);
            label5.Name = "label5";
            label5.Size = new Size(102, 24);
            label5.TabIndex = 9;
            label5.Text = "Gizli Soru:";
            // 
            // cmbPassQuestion
            // 
            cmbPassQuestion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPassQuestion.FormattingEnabled = true;
            cmbPassQuestion.Location = new Point(45, 454);
            cmbPassQuestion.Name = "cmbPassQuestion";
            cmbPassQuestion.Size = new Size(401, 32);
            cmbPassQuestion.TabIndex = 5;
            // 
            // txtSignUpName
            // 
            txtSignUpName.Location = new Point(44, 78);
            txtSignUpName.Name = "txtSignUpName";
            txtSignUpName.Size = new Size(401, 33);
            txtSignUpName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 42);
            label4.Name = "label4";
            label4.Size = new Size(121, 24);
            label4.TabIndex = 6;
            label4.Text = "İsim Soyad:";
            // 
            // txtSignUpPassRepeat
            // 
            txtSignUpPassRepeat.Location = new Point(44, 313);
            txtSignUpPassRepeat.Name = "txtSignUpPassRepeat";
            txtSignUpPassRepeat.Size = new Size(401, 33);
            txtSignUpPassRepeat.TabIndex = 4;
            txtSignUpPassRepeat.TextChanged += SignUpPassRepeat_textBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 281);
            label3.Name = "label3";
            label3.Size = new Size(125, 24);
            label3.TabIndex = 4;
            label3.Text = "Şifre Tekrarı:";
            // 
            // txtSignUpPassword
            // 
            txtSignUpPassword.Location = new Point(45, 236);
            txtSignUpPassword.Name = "txtSignUpPassword";
            txtSignUpPassword.Size = new Size(401, 33);
            txtSignUpPassword.TabIndex = 3;
            txtSignUpPassword.TextChanged += SignUpPass_textBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 203);
            label2.Name = "label2";
            label2.Size = new Size(55, 24);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // txtSignUpMail
            // 
            txtSignUpMail.Location = new Point(45, 157);
            txtSignUpMail.Name = "txtSignUpMail";
            txtSignUpMail.Size = new Size(401, 33);
            txtSignUpMail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 124);
            label1.Name = "label1";
            label1.Size = new Size(74, 24);
            label1.TabIndex = 0;
            label1.Text = "E-Mail:";
            // 
            // SignUpForm
            // 
            AcceptButton = btn_SignUp;
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bacgroundv1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1285, 725);
            Controls.Add(SignUp_GroupBox);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "SignUpForm";
            Text = "Kayıt Ekranı";
            Load += SignUpForm_Load;
            SignUp_GroupBox.ResumeLayout(false);
            SignUp_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpass).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SignUp_GroupBox;
        private TextBox txtSignUpPassRepeat;
        private Label label3;
        private TextBox txtSignUpPassword;
        private Label label2;
        private TextBox txtSignUpMail;
        private Label label1;
        private Button btn_SignUp;
        private TextBox txtSaveAnswer;
        private Label label6;
        private Label label5;
        private ComboBox cmbPassQuestion;
        private TextBox txtSignUpName;
        private Label label4;
        private Label PassStatus;
        private ProgressBar pbpassStr;
        private PictureBox pictureBox1;
        private PictureBox pbpass;
        private PictureBox pictureBox2;
    }
}