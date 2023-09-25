using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Repositories
{
    public class AccountRepository
    {
        ProjectContext db;
        public AccountRepository()
        {
            db = new ProjectContext();
        }

        public void Add(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
        }

        public void Update(Account account) 
        { 
            db.Accounts.Update(account);
            db.SaveChanges();
        }

        /// <summary>
        /// Hesap silme işlemi yapar
        /// </summary>
        /// <param name="account">Entity kullanarak silme işlemi yapar</param>
        public void Delete(Account account)
        {
            db.Accounts.Remove(account);
            db.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"> id kullanarak kullanıcıyı silme</param>
        public void Delete(int id)
        {
            Account account = db.Accounts.Where(a => a.Id == id).FirstOrDefault();
            db.Accounts.Remove(account);
            db.SaveChanges();
        }

        public List<Account> GetAll()
        {
            return db.Accounts.ToList();
        }
    }
}
