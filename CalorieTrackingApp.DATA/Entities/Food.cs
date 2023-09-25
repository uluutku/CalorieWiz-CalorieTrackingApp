using CalorieTrackingApp.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DATA.Entities
{
    public class Food: BaseEntity
    {
        public Food()
        {
            ConsumedFoods = new List<ConsumedFood>();
        }
        public double StandartPortion { get; set; }
        public double PortionProtein { get; set; }
        public double PortionFat { get; set; }
        public double PortionCarb { get; set; }
        public double PortionCalorie { get; set; }
        public byte[]? Photo { get; set; }

        public List<ConsumedFood> ConsumedFoods { get; set; }
    }
}
