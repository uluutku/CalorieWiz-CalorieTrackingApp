using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DATA.Entities
{
    public class SecurityQuestion
    {
        public SecurityQuestion()
        {
            Accounts = new List<Account>();
        }
        public int Id { get; set; }
        public string QestionText { get; set; }

        public List<Account> Accounts { get; set; }
    }
}
