using AppTweet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppTweet.Services
{
    class TwitterService : ITwitterService
    {
    

        public bool authentification(User user)
        {
            bool isValid = true;

            var listTweets = getTweets();
            if(!listTweets.Select(u=>u.User).Any(u =>u.Login == user.Login &&u.Password == u.Password))
            {
                isValid = false;
            }
            return isValid;
        }

        public List<Tweet> getTweets()
        {
            return ListTweets;
        }

        public List<Tweet> ListTweets
        {
            get
            {
                    return new List<Tweet> {
                    new Tweet (1, "06/06/2020", "texte1", new User("tota","tata")),
                    new Tweet (1, "06/06/2020", "texte2", new User("jojo","jojo")),
                    new Tweet (1, "06/06/2020", "texte3", new User("lulu","lulu")),
                    new Tweet (1, "06/06/2020", "texte4", new User("coco","coco")),
                    new Tweet (1, "06/06/2020", "texte5", new User("lili","lili")),
                    };
            }
         }

}
}
