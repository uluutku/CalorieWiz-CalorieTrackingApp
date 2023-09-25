using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DATA.Entities
{
    public class ConsumedWater
    {
        public int Id { get; set; }
        public double Portion { get; set; }
        public DateTime ConsumedTime { get; set; }


        public int AccountID { get; set; }
        public Account Account { get; set; }
    }
}
