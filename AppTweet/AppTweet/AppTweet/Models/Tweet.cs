using System;
using System.Collections.Generic;
using System.Text;

namespace AppTweet.Models
{
    public class Tweet
    {
        public int Id { get; set; }
        public String DateCreation { get; set; }
        public String Text { get; set; }
        public User User { get; set; }

        public Tweet(int tweetId, string dateCreation, string text, User user)
        {
            Id = tweetId;
            DateCreation = dateCreation;
            Text = text;
            User = user;
        }



    }
}
