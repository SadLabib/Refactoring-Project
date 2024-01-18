using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public class Program
    {
        static void Main(string[] args)
        {
            MediaList mediaList = new MediaList();
            MediaManager mediaManager = new MediaManager();
            Movie movie ;
            
            Dashboard dash = new Dashboard(mediaList, mediaManager, movie);
            dash.EnterDashboard();
            Console.ReadKey();

        }

    }
}

