using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieTrackingApp.DATA.Entities
{
    public class LikedAccount
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int SocialMediaPostId { get; set; }
        public SocialMediaPost SocialMediaPost { get; set; }
    }
}
