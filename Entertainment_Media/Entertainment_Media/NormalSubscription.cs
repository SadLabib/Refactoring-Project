using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public class NormalSubscription : ISubscription
    {
        public void Subscribe(User user)
        {
            Console.WriteLine($"{user.Username}, you are now subscribed to the normal plan.");
        }
    }
}
