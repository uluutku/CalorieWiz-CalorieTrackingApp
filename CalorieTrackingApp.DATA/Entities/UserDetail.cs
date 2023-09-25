using CalorieTrackingApp.DATA.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DATA.Entities
{
    public class UserDetail
    {

        public double Height { get; set; }
        public double LastWeight { get; set; }
        public double BMI { get; set; }
        public double ExerciseLevel { get; set; }
        public double TargetWeight { get; set; }
        public double TargetWaterIntake { get; set; } = 2.6;
        public double TargetCalorieIntake { get; set; }
        public Gender Gender { get; set; }
        public byte[]? Picture { get; set; }
        public DateTime BirthDate { get; set; }

        [Key]
        [ForeignKey("Account")]
        public int AccountId { get; set; }
        public Account Account { get; set; }
    }
}
