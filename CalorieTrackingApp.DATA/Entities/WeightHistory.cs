using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DATA.Entities
{
    public class WeightHistory
    {
        public int WeightHistoryId { get; set; }
        public double Weight { get; set; }
        public DateTime WeightDate { get; set; }

        public int AccountID { get; set; }
        public Account Account { get; set; }
    }
}
