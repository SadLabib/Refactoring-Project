using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public class User : IUser
    {
        public string Username { get; set; }
        public ISubscription SubscriptionType { get; set; }

        public User(string username, ISubscription subscriptionType)
        {
            Username = username;
            SubscriptionType = subscriptionType;
        }
    }
}
