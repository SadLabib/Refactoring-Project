﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public class NormalUser:User, ISubscription,IReview
    {
        public NormalUser(string Username,string Email, string Pass)
        {
            this.Username = Username;
            this.Email = Email;
            this.Pass = Pass;
            SubscriptionType = "Normal";
        }

        public void Subscribe()
        {
            Console.WriteLine("Congratulations you have subscribed to Normal Subscription");

        }

        public void GiveReview()
        {
            Console.WriteLine(Username + "gave a review.");
        }
    }
}
