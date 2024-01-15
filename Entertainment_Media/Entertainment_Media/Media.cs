using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public class Media
    {
        public string Type;
        public string Title;
        public int ReleaseYear;
        public Media(string type, string title, int releaseYear)
        {
            Type = type;
            Title = title;
            ReleaseYear = releaseYear;

        }
    }
}
