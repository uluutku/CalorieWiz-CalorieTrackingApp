namespace CalorieTrackingApp.UI
{
    partial class AddWeightData
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
            label3 = new Label();
            btnKaydet = new Button();
            label4 = new Label();
            nudGuncelKilo = new NumericUpDown();
            groupBox6 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            lblBaslangicKilo = new Label();
            label10 = new Label();
            lblDegisenKilo2 = new Label();
            lblDegisenKilo = new Label();
            label7 = new Label();
            lblHedefeKalanKilo2 = new Label();
            lblHedefeKalanKilo = new Label();
            label41 = new Label();
            label1 = new Label();
            dtpDate = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudGuncelKilo).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 820);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.date;
            pictureBox1.Location = new Point(91, 253);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Enabled = false;
            pictureBox6.Image = Properties.Resources.addWeightPanel;
            pictureBox6.Location = new Point(240, 32);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(115, 116);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 52;
            pictureBox6.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(btnKaydet);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(nudGuncelKilo);
            groupBox2.Location = new Point(10, 592);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(557, 206);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kilo Verisi Ekle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 102);
            label3.Name = "label3";
            label3.Size = new Size(145, 24);
            label3.TabIndex = 53;
            label3.Text = "Güncel Kilon:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(373, 97);
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
            label4.Location = new Point(310, 102);
            label4.Name = "label4";
            label4.Size = new Size(35, 24);
            label4.TabIndex = 47;
            label4.Text = "kg";
            // 
            // nudGuncelKilo
            // 
            nudGuncelKilo.Location = new Point(184, 100);
            nudGuncelKilo.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudGuncelKilo.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            nudGuncelKilo.Name = "nudGuncelKilo";
            nudGuncelKilo.Size = new Size(120, 33);
            nudGuncelKilo.TabIndex = 46;
            nudGuncelKilo.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(pictureBox3);
            groupBox6.Controls.Add(pictureBox4);
            groupBox6.Controls.Add(pictureBox2);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(lblBaslangicKilo);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(lblDegisenKilo2);
            groupBox6.Controls.Add(lblDegisenKilo);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(lblHedefeKalanKilo2);
            groupBox6.Controls.Add(lblHedefeKalanKilo);
            groupBox6.Controls.Add(label41);
            groupBox6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(10, 338);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(557, 236);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Kilo İstatistikleri";
            // 
            // pictureBox3
            // 
            pictureBox3.Enabled = false;
            pictureBox3.Image = Properties.Resources.done;
            pictureBox3.Location = new Point(117, 108);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 57;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Enabled = false;
            pictureBox4.Image = Properties.Resources.target;
            pictureBox4.Location = new Point(58, 157);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 56;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Enabled = false;
            pictureBox2.Image = Properties.Resources.start;
            pictureBox2.Location = new Point(118, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(343, 64);
            label8.Name = "label8";
            label8.Size = new Size(31, 21);
            label8.TabIndex = 52;
            label8.Text = "idi.";
            // 
            // lblBaslangicKilo
            // 
            lblBaslangicKilo.AutoSize = true;
            lblBaslangicKilo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaslangicKilo.Location = new Point(275, 58);
            lblBaslangicKilo.Name = "lblBaslangicKilo";
            lblBaslangicKilo.Size = new Size(68, 28);
            lblBaslangicKilo.TabIndex = 51;
            lblBaslangicKilo.Text = "77kg";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(150, 63);
            label10.Name = "label10";
            label10.Size = new Size(122, 21);
            label10.TabIndex = 50;
            label10.Text = "Başlangıç kilon";
            // 
            // lblDegisenKilo2
            // 
            lblDegisenKilo2.AutoSize = true;
            lblDegisenKilo2.Location = new Point(337, 112);
            lblDegisenKilo2.Name = "lblDegisenKilo2";
            lblDegisenKilo2.Size = new Size(63, 21);
            lblDegisenKilo2.TabIndex = 49;
            lblDegisenKilo2.Text = "verdin.";
            // 
            // lblDegisenKilo
            // 
            lblDegisenKilo.AutoSize = true;
            lblDegisenKilo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblDegisenKilo.Location = new Point(276, 106);
            lblDegisenKilo.Name = "lblDegisenKilo";
            lblDegisenKilo.Size = new Size(55, 28);
            lblDegisenKilo.TabIndex = 48;
            lblDegisenKilo.Text = "3kg";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(150, 111);
            label7.Name = "label7";
            label7.Size = new Size(114, 21);
            label7.TabIndex = 47;
            label7.Text = "Şu ana kadar";
            // 
            // lblHedefeKalanKilo2
            // 
            lblHedefeKalanKilo2.AutoSize = true;
            lblHedefeKalanKilo2.Location = new Point(340, 161);
            lblHedefeKalanKilo2.Name = "lblHedefeKalanKilo2";
            lblHedefeKalanKilo2.Size = new Size(136, 21);
            lblHedefeKalanKilo2.TabIndex = 46;
            lblHedefeKalanKilo2.Text = "daha vermelisin.";
            // 
            // lblHedefeKalanKilo
            // 
            lblHedefeKalanKilo.AutoSize = true;
            lblHedefeKalanKilo.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHedefeKalanKilo.Location = new Point(276, 156);
            lblHedefeKalanKilo.Name = "lblHedefeKalanKilo";
            lblHedefeKalanKilo.Size = new Size(55, 28);
            lblHedefeKalanKilo.TabIndex = 45;
            lblHedefeKalanKilo.Text = "2kg";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(90, 162);
            label41.Name = "label41";
            label41.Size = new Size(178, 21);
            label41.TabIndex = 44;
            label41.Text = "Hedefine ulaşmak için";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(150, 185);
            label1.Name = "label1";
            label1.Size = new Size(279, 39);
            label1.TabIndex = 7;
            label1.Text = "Kilo Verisi Kaydet";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(159, 264);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(370, 33);
            dtpDate.TabIndex = 6;
            // 
            // AddWeightData
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 844);
            Controls.Add(groupBox1);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "AddWeightData";
            Text = "Kilo Verisi Değiştirme";
            Load += AddWeightData_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudGuncelKilo).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnKaydet;
        private Label label4;
        private NumericUpDown nudGuncelKilo;
        private GroupBox groupBox6;
        private Label lblHedefeKalanKilo2;
        private Label lblHedefeKalanKilo;
        private Label label41;
        private Label label1;
        private DateTimePicker dtpDate;
        private Label label3;
        private Label label8;
        private Label lblBaslangicKilo;
        private Label label10;
        private Label lblDegisenKilo2;
        private Label lblDegisenKilo;
        private Label label7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}