using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Repositories
{
    public class LikedAccountRepository
    {
        ProjectContext db;
        public LikedAccountRepository()
        {
            db = new ProjectContext();
        }

        public void Add(LikedAccount likedAccount)
        {
            db.LikedAccounts.Add(likedAccount);
            db.SaveChanges();
        }

        public void Update(LikedAccount likedAccount) 
        { 
            db.LikedAccounts.Update(likedAccount);
            db.SaveChanges();
        }

        /// <summary>
        /// Hesap silme işlemi yapar
        /// </summary>
        /// <param name="likedAccount">Entity kullanarak silme işlemi yapar</param>
        public void Delete(LikedAccount likedAccount)
        {
            db.LikedAccounts.Remove(likedAccount);
            db.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"> id kullanarak kullanıcıyı silme</param>
        public void Delete(int id)
        {
            LikedAccount likedAccount = db.LikedAccounts.Where(a => a.Id == id).FirstOrDefault();
            db.LikedAccounts.Remove(likedAccount);
            db.SaveChanges();
        }

        public List<LikedAccount> GetAll()
        {
            return db.LikedAccounts.ToList();
        }
    }
}
