using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public class Movie : Media
    {
        public string Director;
        public Movie(string Type,string Title, int ReleaseYear, string Director) : base(Type, Title, ReleaseYear)
        {
            this.Director = Director;
        }
    }
}



