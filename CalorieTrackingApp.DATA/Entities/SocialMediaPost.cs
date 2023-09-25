using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DATA.Entities
{
    public class SocialMediaPost
    {
        public int SocialMediaPostId { get; set; }
        public byte[]? PostPicture { get; set; }
        public string PostDescription { get; set; }
        public int LikeCount { get; set; } = 0;
        public DateTime PostDate { get; set; }

        public int AccountId { get; set; }
        public Account Account { get; set; }
        public List<LikedAccount> LikedAccounts { get; set; }
    }
}
