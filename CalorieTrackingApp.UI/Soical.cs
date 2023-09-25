using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DATA.Entities;
using CalorieTrackingApp.UI.Helper;
using CalorieTrackingApp.UI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackingApp.UI
{
    public partial class Soical : Form
    {

        Account _account;
        public Soical(Account account)
        {
            _account = account;
            InitializeComponent();
        }

        SocialMediaPostRepository posts;
        AccountRepository accounts;
        LikedAccountRepository likedAccounts;
        string imagePath;
        private void Soical_Load(object sender, EventArgs e)
        {
            BasicTools.TopDetailFiller(topBar_groupBox.Controls, _account.Id);
            posts = new SocialMediaPostRepository();
            accounts = new AccountRepository();
            likedAccounts = new LikedAccountRepository();
            LoadPosts();
        }

        private void LoadPosts()
        {
            flpPosts.Controls.Clear();
            List<SocialMediaPost> postsList = posts.GetAll();
            if (postsList == null)
            {
                Label label = new Label();
                label.Text = "Gösterilecek bir post yoktur.";
                label.Width = 250;
                label.AutoSize = true;
                flpPosts.Controls.Add(label);
            }
            else
            {

                foreach (SocialMediaPost post in postsList)
                {
                    int labelWidth;
                    int labelPosition;
                    GroupBox grp = new GroupBox();
                    grp.Text = BasicTools.FirstLatterUpper(accounts.GetAll().Where(a => a.Id == post.AccountId).FirstOrDefault().Name);
                    if (post.PostPicture != null)
                    {
                        //Resim
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.BackColor = Color.Red;
                        pictureBox.Height = 185;
                        pictureBox.Width = 250;
                        pictureBox.Location = new Point(20, 40);
                        grp.Controls.Add(pictureBox);
                        using (MemoryStream ms = new MemoryStream(post.PostPicture))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }

                        labelWidth = 280;
                        labelPosition = 300;
                    }
                    else
                    {
                        labelWidth = 560;
                        labelPosition = 20;
                    }
                    //Açıklama
                    Label label = new Label();
                    label.Width = labelWidth;
                    label.Height = 185;
                    label.AutoEllipsis = true;
                    Font newFont = new Font("Arial", 12, FontStyle.Regular);
                    label.Font = newFont;
                    label.Text = post.PostDescription.ToString();
                    label.Location = new Point(labelPosition, 40);
                    grp.Controls.Add(label);

                    //Beğeni butonu

                    Button btn = new Button();
                    btn.Location = new Point(20, 227);
                    btn.Height = 30;
                    btn.Width = 130;
                    btn.Tag = post;
                    Font newFont2 = new Font("Arial", 10, FontStyle.Bold);
                    btn.Font = newFont2;

                    if (AccountEsist(post.SocialMediaPostId))
                    {
                        btn.Text = $"Beğenme ({post.LikeCount})";

                        btn.BackColor = Color.Tomato;
                        btn.FlatAppearance.BorderSize = 3;
                    }
                    else
                    {
                        btn.Text = $"Beğen ({post.LikeCount})";
                        btn.BackColor = Color.LightCoral;
                    }

                    btn.FlatStyle = FlatStyle.Flat;

                    btn.FlatAppearance.BorderColor = Color.Salmon;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Click += new EventHandler(likeButton_Click);
                    grp.Controls.Add(btn);

                    //Tarih
                    Label dateLabel = new Label();
                    dateLabel.Location = new Point(430, 232);
                    dateLabel.Width = 165;
                    dateLabel.Text = post.PostDate.ToString();
                    Font newFont3 = new Font("Arial", 9, FontStyle.Italic);
                    dateLabel.Font = newFont3;
                    grp.Controls.Add(dateLabel);

                    //DeleteIcon
                    if (post.AccountId == _account.Id)
                    {
                        PictureBox picture2 = new PictureBox();
                        picture2.Image = Properties.Resources.xIcon;
                        picture2.SizeMode = PictureBoxSizeMode.StretchImage;
                        picture2.Size = new Size(15, 15);
                        picture2.Location = new Point(580, 17);
                        picture2.BringToFront();
                        picture2.Click += new EventHandler(picture2_Click);
                        picture2.Tag = post;
                        grp.Controls.Add(picture2);

                    }

                    //GroupBox
                    grp.Height = 260;
                    grp.Width = 600;
                    grp.Margin = new Padding(20, 0, 0, 10);
                    flpPosts.Controls.Add(grp);
                }
            }
        }

        private void picture2_Click(object? sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            DialogResult res = MessageBox.Show("Post u silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                SocialMediaPost post = pictureBox.Tag as SocialMediaPost;
                posts.Delete(post);
                LoadPosts();
            }
        }

        private bool AccountEsist(int postId)
        {

            return likedAccounts.GetAll().Any(l => l.SocialMediaPostId == postId && l.AccountId == _account.Id);
        }

        private void likeButton_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            SocialMediaPost post = btn.Tag as SocialMediaPost;
            int likeCount = post.LikeCount;

            if (btn.BackColor == Color.LightCoral)
            {
                likeCount += 1;
                btn.Text = $"Beğenme ({likeCount})";

                btn.BackColor = Color.Tomato;
                btn.FlatAppearance.BorderSize = 3;

                LikedAccount liked = new LikedAccount()
                {
                    AccountId = _account.Id,
                    SocialMediaPostId = post.SocialMediaPostId,
                };
                likedAccounts.Add(liked);
            }
            else
            {
                likeCount -= 1;
                btn.Text = $"Beğen ({likeCount})";

                btn.BackColor = Color.LightCoral;
                btn.FlatAppearance.BorderSize = 0;

                int laId = likedAccounts.GetAll().Where(l => l.SocialMediaPostId == post.SocialMediaPostId && l.AccountId == _account.Id).First().Id;
                likedAccounts.Delete(laId);
            }

            post.LikeCount = likeCount;
            posts.Update(post);

        }

        private void tbPostDetail_TextChanged(object sender, EventArgs e)
        {
            int TextLength = txtPostDetail.Text.Length;
            lbCounter.Text = $"{TextLength}/255";
        }

        //Resim ekleme
        private void pbPostPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pbPostPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                pbPostPicture.Image = Image.FromFile(ofd.FileName);
            }

        }

        //post ekleme
        private void btnPost_Click(object sender, EventArgs e)
        {
            if (txtPostDetail.Text != string.Empty)
            {
                SocialMediaPost socialMediaPost = new SocialMediaPost();

                if (imagePath != null)
                {
                    socialMediaPost.PostPicture = File.ReadAllBytes(imagePath);
                }
                else
                {
                    socialMediaPost.PostPicture = null;
                }

                socialMediaPost.PostDescription = txtPostDetail.Text;
                socialMediaPost.PostDate = DateTime.Now;
                socialMediaPost.AccountId = _account.Id;

                posts.Add(socialMediaPost);
                LoadPosts();

                pbPostPicture.Image = default;
                txtPostDetail.Text = string.Empty;
                imagePath = null;
            }
            else
            {
                MessageBox.Show("Yorum yazmadan post gönderilemez", "Boşluk!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void exit_navbar_Click(object sender, EventArgs e)
        {
            Navigations.GotoExit(_account, this);
        }

        private void reports_navBtn_Click(object sender, EventArgs e)
        {
            Navigations.GotoDailyReport(_account, this);
        }

        private void LongReport_navbar_Click(object sender, EventArgs e)
        {
            Navigations.GotoLongReport(_account, this);
        }

        private void mainMenu_navBtn_Click(object sender, EventArgs e)
        {
            Navigations.GotoMainMenu(_account, this);
        }

        private void lblProfileNameTop1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Navigations.GotoProfile(_account, this);
        }
    }
}
