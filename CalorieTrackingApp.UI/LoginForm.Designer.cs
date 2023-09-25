namespace CalorieTrackingApp.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginGroupBox = new GroupBox();
            pictureBox1 = new PictureBox();
            pbpass = new PictureBox();
            txtLoginPassword = new TextBox();
            lklblRegister = new LinkLabel();
            label3 = new Label();
            btnEntry = new Button();
            linkLabel1 = new LinkLabel();
            chkRememberMe = new CheckBox();
            label2 = new Label();
            txtLoginUsername = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            LoginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LoginGroupBox
            // 
            LoginGroupBox.BackColor = Color.Transparent;
            LoginGroupBox.BackgroundImage = Properties.Resources.output_onlinepngtools;
            LoginGroupBox.BackgroundImageLayout = ImageLayout.Stretch;
            LoginGroupBox.Controls.Add(pictureBox2);
            LoginGroupBox.Controls.Add(pictureBox1);
            LoginGroupBox.Controls.Add(pbpass);
            LoginGroupBox.Controls.Add(txtLoginPassword);
            LoginGroupBox.Controls.Add(lklblRegister);
            LoginGroupBox.Controls.Add(label3);
            LoginGroupBox.Controls.Add(btnEntry);
            LoginGroupBox.Controls.Add(linkLabel1);
            LoginGroupBox.Controls.Add(chkRememberMe);
            LoginGroupBox.Controls.Add(label2);
            LoginGroupBox.Controls.Add(txtLoginUsername);
            LoginGroupBox.Controls.Add(label1);
            LoginGroupBox.FlatStyle = FlatStyle.Popup;
            LoginGroupBox.Location = new Point(723, 43);
            LoginGroupBox.Name = "LoginGroupBox";
            LoginGroupBox.Size = new Size(438, 646);
            LoginGroupBox.TabIndex = 0;
            LoginGroupBox.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.witch_hat;
            pictureBox1.Location = new Point(307, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pbpass
            // 
            pbpass.BackColor = Color.White;
            pbpass.BackgroundImageLayout = ImageLayout.None;
            pbpass.Image = Properties.Resources.eye;
            pbpass.Location = new Point(378, 282);
            pbpass.Margin = new Padding(3, 2, 3, 2);
            pbpass.Name = "pbpass";
            pbpass.Size = new Size(29, 28);
            pbpass.SizeMode = PictureBoxSizeMode.StretchImage;
            pbpass.TabIndex = 9;
            pbpass.TabStop = false;
            pbpass.MouseDown += pbpass_MouseDown;
            pbpass.MouseUp += pbpass_MouseUp;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(39, 279);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(373, 33);
            txtLoginPassword.TabIndex = 2;
            // 
            // lklblRegister
            // 
            lklblRegister.AutoSize = true;
            lklblRegister.Location = new Point(279, 557);
            lklblRegister.Name = "lklblRegister";
            lklblRegister.Size = new Size(88, 24);
            lklblRegister.TabIndex = 6;
            lklblRegister.TabStop = true;
            lklblRegister.Text = "Kayıt Ol";
            lklblRegister.LinkClicked += lklblRegister_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 557);
            label3.Name = "label3";
            label3.Size = new Size(200, 24);
            label3.TabIndex = 8;
            label3.Text = "Hesabınız yok mu?";
            // 
            // btnEntry
            // 
            btnEntry.Location = new Point(109, 459);
            btnEntry.Name = "btnEntry";
            btnEntry.Size = new Size(223, 47);
            btnEntry.TabIndex = 3;
            btnEntry.Text = "Giriş Yap";
            btnEntry.UseVisualStyleBackColor = true;
            btnEntry.Click += btnEntry_Click;
            btnEntry.Enter += btnEntry_Enter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(130, 412);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(181, 21);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Şifrenizi mi Unuttunuz?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel1.Enter += linkLabel1_Enter;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Location = new Point(42, 333);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(142, 28);
            chkRememberMe.TabIndex = 4;
            chkRememberMe.Text = "Beni Hatırla";
            chkRememberMe.UseVisualStyleBackColor = true;
            chkRememberMe.CheckedChanged += chkRememberMe_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 245);
            label2.Name = "label2";
            label2.Size = new Size(55, 24);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(42, 199);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(370, 33);
            txtLoginUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 166);
            label1.Name = "label1";
            label1.Size = new Size(141, 24);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 64);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(280, 83);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AcceptButton = btnEntry;
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bacgroundv1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1192, 753);
            Controls.Add(LoginGroupBox);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            LoginGroupBox.ResumeLayout(false);
            LoginGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox LoginGroupBox;
        private Button btnEntry;
        private LinkLabel linkLabel1;
        private CheckBox chkRememberMe;
        private Label label2;
        private TextBox txtLoginUsername;
        private Label label1;
        private LinkLabel lklblRegister;
        private Label label3;
        private TextBox txtLoginPassword;
        private PictureBox pbpass;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}