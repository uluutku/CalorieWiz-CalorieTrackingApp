using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Repositories
{
    public class UserDetailRepository
    {
        ProjectContext db;
        public UserDetailRepository()
        {
            db = new ProjectContext();
        }

        public void Add(UserDetail userDetail)
        {
            db.UserDetails.Add(userDetail);
            db.SaveChanges();
        }

        public void Update(UserDetail userDetail) 
        { 
            db.UserDetails.Update(userDetail);
            db.SaveChanges();
        }

        public List<UserDetail> GetAll()
        {
            return db.UserDetails.ToList();
        }
    }
}
