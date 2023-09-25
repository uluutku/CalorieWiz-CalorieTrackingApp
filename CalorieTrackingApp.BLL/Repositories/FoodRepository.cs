using CalorieTrackingApp.DAL.Context;
using CalorieTrackingApp.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.BLL.Repositories
{
    public class FoodRepository
    {
        ProjectContext db;
        public FoodRepository()
        {
            db = new ProjectContext();
        }

        public void Add(Food food)
        {
            db.Foods.Add(food);
            db.SaveChanges();
        }

        public void Update(Food food) 
        { 
            db.Foods.Update(food);
            db.SaveChanges();
        }

        /// <summary>
        /// Yiyecek silme işlemi yapar
        /// </summary>
        /// <param name="food">Entity kullanarak silme işlemi yapar</param>
        public void Delete(Food food)
        {
            db.Foods.Remove(food);
            db.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"> id kullanarak Yiyecek silme</param>
        public void Delete(int id)
        {
            Food food = db.Foods.Where(a => a.Id == id).FirstOrDefault();
            db.Foods.Remove(food);
            db.SaveChanges();
        }

        public List<Food> GetAll()
        {
            return db.Foods.ToList();
        }

        public Food GetByName(string name)
        {
            Food food = db.Foods.FirstOrDefault(f => f.Name == name);          
            return food;
        }

    }
}
