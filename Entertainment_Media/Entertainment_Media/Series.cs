using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public class Series : Media,IMedia,IWatch
    {   
        public int TotalSeason { get; set; }
        public int TotalEpisode { get; set; }
        public string Director { get; set; }

        public Series(string Type, string Title, int Year, string Director, int TotalEpisode, int TotalSeason) : base(Type, Title, Year)
        {
            this.TotalSeason = TotalSeason;
            this.TotalEpisode = TotalEpisode;
            this.Director = Director;
        }
        public void GetDetails()
        {
            Console.WriteLine("Drama Series:");
            Console.WriteLine($"Type: {this.Type}");
            Console.WriteLine($"Title: {this.Title}");
            Console.WriteLine($"Release Year: {this.Year.ToString()}");
            Console.WriteLine($"Director: {this.Director}");
            Console.WriteLine($"Total Seasons: {this.TotalSeason}");
            Console.WriteLine($"Total Episodes: {this.TotalEpisode}");
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
