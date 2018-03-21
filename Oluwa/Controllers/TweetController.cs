using Oluwa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oluwa.Controllers
{
    public class TweetController : Controller
    {
        List<Tweet> tweets;

        public TweetController()
        {
            tweets = new List<Tweet>(); //retrieve tweets from db

            Tweet tweet = new Tweet();
            tweet.Id = 1;
            tweet.Content = "First Tweet on the app";
            tweet.User = "@Ade";
            tweet.NoOfLikes = 12;
            tweet.TweetedAt = DateTime.Now;
            tweets.Add(tweet);


            tweet = new Tweet();
            tweet.Id = 2;
            tweet.Content = "Second Tweet on the app";
            tweet.User = "@Ade";
            tweet.TweetedAt = DateTime.Now;

            tweets.Add(tweet);
        }
        // GET: All Tweets
        public ActionResult Index()
        {
            //Connect to database
            //Retrieve all tweets based on our followers
            return View(tweets);
        }

        // POST a Tweet
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Post(Tweet tweet)
        {
            tweets.Add(tweet);
            return View("Index",tweets);
        }

        // GET a single Tweet
        public ActionResult View(int Id)
        {
            return View();
        }
    }
}