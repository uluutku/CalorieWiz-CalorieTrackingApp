using CalorieTrackingApp.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DATA.Entities
{
    public class ConsumedFood
    {
        public int ConsumedFoodId { get; set; }
        public DateTime ConsumedDate { get; set; } = DateTime.Now;
        public double Portion { get; set; }
        public int ConsumedCount { get; set; }
        public byte[]? Photo { get; set; }
        public DateTime ConsumedTime { get; set; }
        public MealCategory MealCategory { get; set; }

        public int AccountID { get; set; }
        public int FoodID { get; set; }
        public Account Account { get; set; }
        public Food Food { get; set; }
    }
}
