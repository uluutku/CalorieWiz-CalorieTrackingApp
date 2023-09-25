using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Repositories
{
    public class WeightHistoryRepository
    {
        ProjectContext db;
        public WeightHistoryRepository()
        {
            db = new ProjectContext();
        }

        public void Add(WeightHistory weightHistory)
        {
            db.WeightHistories.Add(weightHistory);
            db.SaveChanges();
        }

        public void Update(WeightHistory weightHistory) 
        { 
            db.WeightHistories.Update(weightHistory);
            db.SaveChanges();
        }

        /// <summary>
        /// Yiyecek silme işlemi yapar
        /// </summary>
        /// <param name="weightHistory">Entity kullanarak silme işlemi yapar</param>
        public void Delete(WeightHistory weightHistory)
        {
            db.WeightHistories.Remove(weightHistory);
            db.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"> id kullanarak Yiyecek silme</param>
        public void Delete(int id)
        {
            WeightHistory weightHistory = db.WeightHistories.Where(a => a.WeightHistoryId == id).FirstOrDefault();
            db.WeightHistories.Remove(weightHistory);
            db.SaveChanges();
        }

        public List<WeightHistory> GetAll()
        {
            return db.WeightHistories.ToList();
        }
    }
}
