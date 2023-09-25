using CalorieTrackingApp.BLL.Repositories;
using CalorieTrackingApp.DATA.Entities;

namespace CalorieTrackingApp.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AccountRepository accountRepository = new AccountRepository();
            Account account = accountRepository.GetAll().Where(a => a.Id == 1).FirstOrDefault();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Profile(account));
            //Application.Run(new LongReports(account));
            //Application.Run(new MainMenu(account));
            //Application.Run(new Soical(account));
            Application.Run(new LoginForm());
            //Application.Run(new SubMenuMDI(account));
        }
    }
}