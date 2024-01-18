using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public class PremiumUser:User,ISubscription
    {
        public PremiumUser(string Username, string Email, string Pass)
        {
            this.Username = Username;
            this.Email = Email;
            this.Pass = Pass;
            SubscriptionType = "Premium";
        }
        public void Subscribe()
        {
            Console.WriteLine("Congratulations you have subscribed to Premium subscription!");
        }
    }
}
