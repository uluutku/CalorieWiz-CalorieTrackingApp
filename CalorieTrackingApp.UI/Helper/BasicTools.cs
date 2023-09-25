using CalorieTrackingApp.BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieTrackingApp.UI.Helper
{
    static public class BasicTools
    {
        public static string FirstLatterUpper(string input)
        {
            string[] words = input.ToLower().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(words[i]))
                {
                    char[] letters = words[i].ToCharArray();
                    if (letters.Length > 0)
                    {
                        letters[0] = char.ToUpper(letters[0]);
                        words[i] = new string(letters);
                    }
                }
            }
            return string.Join(" ", words);
        }

        public static void TopDetailFiller(Control.ControlCollection control, int id)
        {
            AccountRepository accounts = new AccountRepository();
            UserDetailRepository users = new UserDetailRepository();
            foreach (Control child in control)
            {
                if(child.Name == "pbProfilePictureTop")
                {
                    PictureBox pictureBox = child as PictureBox;
                    using (MemoryStream ms = new MemoryStream(users.GetAll().Where(x => x.AccountId == id).FirstOrDefault().Picture))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }

                    GraphicsPath obj = new GraphicsPath();
                    obj.AddEllipse(0, 0, pictureBox.Width, pictureBox.Height);
                    Region rg = new Region(obj);
                    pictureBox.Region = rg;
                }
                if(child.Name == "lblProfileNameTop1" || child.Name == "lblProfileNameTop2")
                {
                    child.Text = FirstLatterUpper(accounts.GetAll().Where(x=> x.Id == id).FirstOrDefault().Name);
                }
            }
        }
    }
}
