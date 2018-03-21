using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Oluwa.Models
{
    public class Tweet
    {
        public int Id { get; set; }

        [Display(Name ="Tweet")]
        public string Content { get; set; }

        [Display(Name = "Handle")]
        public string User { get; set; }

        [Display(Name = "Likes")]
        public int NoOfLikes { get; set; }

        [Display(Name = "Retweets")]
        public int NoOfRetweets { get; set; }

        [Display(Name = "Time")]
        public DateTime TweetedAt { get; set; }

    }
}