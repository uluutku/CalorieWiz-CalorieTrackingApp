using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Repositories
{
    public class SocialMediaPostRepository
    {
        ProjectContext db;
        public SocialMediaPostRepository()
        {
            db = new ProjectContext();
        }

        public void Add(SocialMediaPost socialMediaPost)
        {
            db.SocialMediaPosts.Add(socialMediaPost);
            db.SaveChanges();
        }

        public void Update(SocialMediaPost socialMediaPost) 
        { 
            db.SocialMediaPosts.Update(socialMediaPost);
            db.SaveChanges();
        }

        /// <summary>
        /// Sosyal medya postu silme işlemi yapar
        /// </summary>
        /// <param name="socialMediaPost">Entity kullanarak silme işlemi yapar</param>
        public void Delete(SocialMediaPost socialMediaPost)
        {
            db.SocialMediaPosts.Remove(socialMediaPost);
            db.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"> id kullanarak Sosyal medya postu silme</param>
        public void Delete(int id)
        {
            SocialMediaPost socialMediaPost = db.SocialMediaPosts.Where(a => a.SocialMediaPostId == id).FirstOrDefault();
            db.SocialMediaPosts.Remove(socialMediaPost);
            db.SaveChanges();
        }

        public List<SocialMediaPost> GetAll()
        {
            return db.SocialMediaPosts.ToList();
        }
    }
}
