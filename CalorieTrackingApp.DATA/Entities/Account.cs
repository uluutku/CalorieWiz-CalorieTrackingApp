using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DATA.Entities
{
    public class Account:BaseEntity
    {
        public Account()
        {
            SocialMediaPosts = new List<SocialMediaPost>();
            ConsumedFoods = new List<ConsumedFood>();
            ConsumedWaters = new List<ConsumedWater>();
            WeightHistories = new List<WeightHistory>();
        }
        public string Password { get; set; }
        public string EMail { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public string QuestionAnswer { get; set; }
        public DateTime DateOfEntry { get; set; }
        public int SecurityQuestionId { get; set; }

        public UserDetail UserDetail { get; set; }
        public SecurityQuestion SecurityQuestion { get; set; }
        public List<SocialMediaPost> SocialMediaPosts { get; set; }
        public List<ConsumedFood> ConsumedFoods { get; set; }
        public List<ConsumedWater> ConsumedWaters { get; set; }
        public List<WeightHistory> WeightHistories { get; set; }
    }
}
