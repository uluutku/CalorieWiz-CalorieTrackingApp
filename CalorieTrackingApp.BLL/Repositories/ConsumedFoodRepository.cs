using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Repositories
{
    public class ConsumedFoodRepository
    {
        ProjectContext db;
        public ConsumedFoodRepository()
        {
            db = new ProjectContext();
        }

        public void Add(ConsumedFood consumedFood)
        {
            db.ConsumedFoods.Add(consumedFood);
            db.SaveChanges();
        }

        public void Update(ConsumedFood consumedFood)
        {
            db.ConsumedFoods.Update(consumedFood);
            db.SaveChanges();
        }

        /// <summary>
        /// tüketilen yemek silme işlemi yapar
        /// </summary>
        /// <param name="consumedFood">Entity kullanarak silme işlemi yapar</param>
        public void Delete(ConsumedFood consumedFood)
        {
            db.ConsumedFoods.Remove(consumedFood);
            db.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"> id kullanarak Tüketilen yiyeceği silme</param>
        public void Delete(int id)
        {
            ConsumedFood consumedFood = db.ConsumedFoods.Where(a => a.ConsumedFoodId == id).FirstOrDefault();
            db.ConsumedFoods.Remove(consumedFood);
            db.SaveChanges();
        }

        public List<ConsumedFood> GetAll()
        {
            return db.ConsumedFoods.ToList();
        }

        public ConsumedFood GetByName(string name)
        {
            ConsumedFood consumedFood = (from cf in db.ConsumedFoods
                                         join f in db.Foods on cf.FoodID equals f.Id
                                         where f.Name == name
                                         select cf)
                                        .FirstOrDefault();
            return consumedFood;
        }
    }
}
