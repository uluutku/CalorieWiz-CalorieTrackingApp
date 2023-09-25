namespace CalorieTrackingApp.UI
{
    partial class SignPassword
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
            grpPassword = new GroupBox();
            lblPassStatus = new Label();
            prbPassStr = new ProgressBar();
            txtSignUpPassRepeat = new TextBox();
            label3 = new Label();
            txtSignUpPass1 = new TextBox();
            label2 = new Label();
            btnPassReset = new Button();
            grpPassword.SuspendLayout();
            SuspendLayout();
            // 
            // grpPassword
            // 
            grpPassword.Controls.Add(lblPassStatus);
            grpPassword.Controls.Add(prbPassStr);
            grpPassword.Controls.Add(txtSignUpPassRepeat);
            grpPassword.Controls.Add(label3);
            grpPassword.Controls.Add(txtSignUpPass1);
            grpPassword.Controls.Add(label2);
            grpPassword.Location = new Point(27, 22);
            grpPassword.Margin = new Padding(5);
            grpPassword.Name = "grpPassword";
            grpPassword.Padding = new Padding(5);
            grpPassword.Size = new Size(595, 309);
            grpPassword.TabIndex = 26;
            grpPassword.TabStop = false;
            // 
            // lblPassStatus
            // 
            lblPassStatus.AutoSize = true;
            lblPassStatus.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassStatus.Location = new Point(14, 245);
            lblPassStatus.Margin = new Padding(5, 0, 5, 0);
            lblPassStatus.Name = "lblPassStatus";
            lblPassStatus.Size = new Size(14, 20);
            lblPassStatus.TabIndex = 20;
            lblPassStatus.Text = "-";
            // 
            // prbPassStr
            // 
            prbPassStr.Location = new Point(12, 203);
            prbPassStr.Margin = new Padding(5);
            prbPassStr.Name = "prbPassStr";
            prbPassStr.Size = new Size(547, 29);
            prbPassStr.TabIndex = 19;
            // 
            // txtSignUpPassRepeat
            // 
            txtSignUpPassRepeat.Location = new Point(10, 142);
            txtSignUpPassRepeat.Margin = new Padding(5);
            txtSignUpPassRepeat.Name = "txtSignUpPassRepeat";
            txtSignUpPassRepeat.Size = new Size(546, 33);
            txtSignUpPassRepeat.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 114);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 24);
            label3.TabIndex = 17;
            label3.Text = "Şifre Tekrarı:";
            // 
            // txtSignUpPass1
            // 
            txtSignUpPass1.Location = new Point(10, 54);
            txtSignUpPass1.Margin = new Padding(5);
            txtSignUpPass1.Name = "txtSignUpPass1";
            txtSignUpPass1.Size = new Size(546, 33);
            txtSignUpPass1.TabIndex = 1;
            txtSignUpPass1.TextChanged += txtSignUpPass1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 26);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 24);
            label2.TabIndex = 15;
            label2.Text = "Şifre:";
            // 
            // btnPassReset
            // 
            btnPassReset.Location = new Point(296, 349);
            btnPassReset.Margin = new Padding(5);
            btnPassReset.Name = "btnPassReset";
            btnPassReset.Size = new Size(326, 51);
            btnPassReset.TabIndex = 3;
            btnPassReset.Text = "ŞİFREYİ SIFIRLA";
            btnPassReset.UseVisualStyleBackColor = true;
            btnPassReset.Click += btnPassReset_Click;
            // 
            // SignPassword
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 414);
            Controls.Add(btnPassReset);
            Controls.Add(grpPassword);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "SignPassword";
            Text = "Şİfre Değiştir";
            Load += SignPassword_Load;
            grpPassword.ResumeLayout(false);
            grpPassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpPassword;
        private Label lblPassStatus;
        private ProgressBar prbPassStr;
        private TextBox txtSignUpPassRepeat;
        private Label label3;
        private TextBox txtSignUpPass1;
        private Label label2;
        private Button btnPassReset;
    }
}