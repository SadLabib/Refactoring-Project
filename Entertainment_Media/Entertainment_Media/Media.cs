using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public abstract class Media
    {
        public string Title { get; set; }
        public string Type{ get; set; }
        public int Year { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();

        public Media(string type,string title,int year)
        {
            
            Type = type;
            Title = title;
            Year = year;
        }

        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }

    }
}
