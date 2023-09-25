using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Repositories
{
    public class ConsumedWaterRepository
    {
        ProjectContext db;
        public ConsumedWaterRepository()
        {
            db = new ProjectContext();
        }

        public void Add(ConsumedWater consumedWater)
        {
            db.ConsumedWaters.Add(consumedWater);
            db.SaveChanges();
        }

        public void Update(ConsumedWater consumedWater) 
        { 
            db.ConsumedWaters.Update(consumedWater);
            db.SaveChanges();
        }

        /// <summary>
        /// Tüeketilen su silme işlemi yapar
        /// </summary>
        /// <param name="ConsumedWater">Entity kullanarak silme işlemi yapar</param>
        public void Delete(ConsumedWater consumedWater)
        {
            db.ConsumedWaters.Remove(consumedWater);
            db.SaveChanges();
        }

        /// <summary>
        /// Tüeketilen su silme işlemi yapar
        /// </summary>
        /// <param name="id"> id kullanarak Tüeketilen su silme</param>
        public void Delete(int id)
        {
            ConsumedWater consumedWater = db.ConsumedWaters.Where(a => a.Id == id).FirstOrDefault();
            db.ConsumedWaters.Remove(consumedWater);
            db.SaveChanges();
        }

        public List<ConsumedWater> GetAll()
        {
            return db.ConsumedWaters.ToList();
        }
    }
}
