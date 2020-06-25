using AppTweet.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTweet.Services
{
    interface ITwitterService
    {
        bool authentification(User user);
        List<Tweet> getTweets();
    }
}
