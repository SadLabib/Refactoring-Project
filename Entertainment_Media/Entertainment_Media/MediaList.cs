using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public class MediaList
    {
        public List<Movie> movielist = new List<Movie>();
        public List<Series> seriesList = new List<Series>();
        public MediaList() 
        {
            Movie actionMovie = new Movie("Action", "The Matrix", 1999, "Lana Wachowski");
            Movie comedyMovie = new Movie("Comedy", "Dumb and Dumber", 1994, "Peter Farrelly");
            Movie dramaMovie = new Movie("Drama", "The Shawshank Redemption", 1994, "Frank Darabont");
            Movie sciFiMovie = new Movie("Science Fiction", "Blade Runner", 1982, "Ridley Scott");
            Movie animatedMovie = new Movie("Animated", "The Lion King", 1994, "Roger Allers");


            Series series1 = new Series("Drama", "Breaking Bad", 2008, "Vince Gilligan", 62, 5);
            Series series2 = new Series("Science Fiction", "Stranger Things", 2016, "Duffer Brothers", 34, 4);
            Series series3 = new Series("Fantasy", "Game of Thrones", 2011, "David Benioff and D. B. Weiss", 73, 8);
            Series prisonBreak = new Series("Action", "Prison Break", 2005, "Paul Scheuring", 5, 81);
            Series sherlockHolmes = new Series("Crime", "Sherlock Holmes", 2010, "Mark Gatiss, Steven Moffat", 4, 13);

            movielist.Add(actionMovie);
            movielist.Add(comedyMovie);
            movielist.Add(dramaMovie);
            movielist.Add(sciFiMovie);
            movielist.Add(animatedMovie);

            seriesList.Add(series1);
            seriesList.Add(series2);
            seriesList.Add(series3);
            seriesList.Add(prisonBreak);
            seriesList.Add(sherlockHolmes);

        }
    }
}
