using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.UI.Helper
{
    static public class Navigations
    {
        public static void GotoMainMenu(Account account, Form frm)
        {
            MainMenu form = new MainMenu(account);
            form.MdiParent = (frm.MdiParent as SubMenuMDI);
            (frm.MdiParent as SubMenuMDI).Size = new Size(form.Width, form.Height);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            CloseMDIs(frm);
        }

        public static void GotoProfile(Account account, Form frm)
        {
            Profile form = new Profile(account);
            form.MdiParent = (frm.MdiParent as SubMenuMDI);
            (frm.MdiParent as SubMenuMDI).Size = new Size(form.Width, form.Height);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            CloseMDIs(frm);
        }

        public static void GotoConsumedFood(Account account, Form frm)
        {
            AddConsumedFood form = new AddConsumedFood(account);
            form.MdiParent = (frm.MdiParent as SubMenuMDI);
            (frm.MdiParent as SubMenuMDI).Size = new Size(form.Width, form.Height);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            CloseMDIs(frm);
        }

        public static void GotoDailyReport(Account account, Form frm)
        {
            DailyReport form = new DailyReport(account);
            form.MdiParent = (frm.MdiParent as SubMenuMDI);
            (frm.MdiParent as SubMenuMDI).Size = new Size(form.Width, form.Height);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            CloseMDIs(frm);
        }

        public static void GotoLongReport(Account account, Form frm)
        {
            LongReports form = new LongReports(account);
            form.MdiParent = (frm.MdiParent as SubMenuMDI);
            (frm.MdiParent as SubMenuMDI).Size = new Size(form.Width, form.Height);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            CloseMDIs(frm);
        }

        public static void GotoSocial(Account account, Form frm)
        {
            Soical form = new Soical(account);
            form.MdiParent = (frm.MdiParent as SubMenuMDI);
            (frm.MdiParent as SubMenuMDI).Size = new Size(form.Width, form.Height);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            CloseMDIs(frm);
        }

        public static void GotoExit(Account account, Form frm)
        {
            DialogResult res = MessageBox.Show("Programı kapatmak istediğinize emin misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (res == DialogResult.Yes)
            {
                frm.MdiParent.Close();
                frm.Close();
            }
            
        }
        public static void CloseMDIs(Form form)
        {
            foreach (Form frm in form.MdiChildren)
            {
                frm.Close();
            }
        }
    }
}
