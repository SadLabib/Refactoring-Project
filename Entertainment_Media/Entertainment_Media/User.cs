using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public abstract class User
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public string Pass { get; set; }
        public string SubscriptionType { get; set; }

  
    }
}
