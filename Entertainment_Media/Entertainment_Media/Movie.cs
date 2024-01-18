using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public class Movie : Media,IMedia,IWatch
    {
        public string Director;
        public Movie(string Type,string Title, int Year, string Director) : base(Type, Title, Year)
        {
            this.Director = Director;
        }
        public void GetDetails()
        {
            Console.WriteLine("Movie Details:");
            Console.WriteLine($"Type: {this.Type}");
            Console.WriteLine($"Title: {this.Title}");
            Console.WriteLine($"Release Year: {this.Year.ToString()}");
            Console.WriteLine($"Director: {this.Director}");
        }

        public void Play()
        {
            Console.WriteLine("Movie Played.");
        }
        public void Pause()
        {
            Console.WriteLine("Movie Paused.");
        }
        public void Stop()
        {
            Console.WriteLine("Movie Stopped.");
        }
    }
}



