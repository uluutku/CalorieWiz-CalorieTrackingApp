namespace CalorieTrackingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(588, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 548);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giriş Yap";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.Location = new Point(148, 385);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(180, 21);
            linkLabel2.TabIndex = 15;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Şifrenizi mi unuttunuz?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = SystemColors.HotTrack;
            linkLabel1.LinkColor = SystemColors.ActiveCaptionText;
            linkLabel1.Location = new Point(273, 483);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(88, 24);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kayıt Ol";
            linkLabel1.VisitedLinkColor = Color.FromArgb(128, 128, 255);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(117, 486);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 13;
            label3.Text = "Hesabınız yok mu?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(34, 244);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(116, 25);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Beni Hatırla";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(118, 306);
            button1.Name = "button1";
            button1.Size = new Size(241, 46);
            button1.TabIndex = 10;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 162);
            label2.Name = "label2";
            label2.Size = new Size(51, 22);
            label2.TabIndex = 9;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 82);
            label1.Name = "label1";
            label1.Size = new Size(123, 22);
            label1.TabIndex = 8;
            label1.Text = "Kullanıcı Adı:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(432, 33);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(432, 33);
            textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.diana_polekhina_ZSpkUThb7qk_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1185, 755);
            Controls.Add(groupBox1);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label3;
    }
}