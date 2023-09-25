using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Repositories
{
    public class SecurityQuestionRepository
    {
        ProjectContext db;
        public SecurityQuestionRepository()
        {
            db = new ProjectContext();
        }

        public void Add(SecurityQuestion securityQuestion)
        {
            db.SecurityQuestions.Add(securityQuestion);
            db.SaveChanges();
        }

        public void Update(SecurityQuestion securityQuestion) 
        { 
            db.SecurityQuestions.Update(securityQuestion);
            db.SaveChanges();
        }

        /// <summary>
        /// Güvenlik Sorusu silme işlemi yapar
        /// </summary>
        /// <param name="securityQuestion">Entity kullanarak silme işlemi yapar</param>
        public void Delete(SecurityQuestion securityQuestion)
        {
            db.SecurityQuestions.Remove(securityQuestion);
            db.SaveChanges();
        }

        /// <summary>
        /// Güvenlik Sorusu silme işlemi yapar
        /// </summary>
        /// <param name="id"> id kullanarak Güvenlik Sorusu silme</param>
        public void Delete(int id)
        {
            SecurityQuestion securityQuestion = db.SecurityQuestions.Where(a => a.Id == id).FirstOrDefault();
            db.SecurityQuestions.Remove(securityQuestion);
            db.SaveChanges();
        }

        public List<SecurityQuestion> GetAll()
        {
            return db.SecurityQuestions.ToList();
        }
    }
}
