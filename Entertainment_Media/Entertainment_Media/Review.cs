using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public class Review : IReview
    {
        public User User { get; set; }
        public string Comment { get; set; }

        public Review(User user, string comment)
        {
            User = user;
            Comment = comment;
        }
    }
}
