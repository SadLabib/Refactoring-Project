using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment_Media
{
    public class Dashboard
    {
        MediaList MediaList { get; set; }
        MediaManager MediaManager { get; set; }

        Movie Movie;
        Series Series;

        public Dashboard(MediaList mediaList, MediaManager mediaManager)
        {
            MediaList = mediaList;
            MediaManager = mediaManager;
        }

        public void EnterDashboard()
        {
            Console.WriteLine("1. Subscribe to Normal Plan");
            Console.WriteLine("2. Subscribe to Premium Plan");
            Console.WriteLine("3. About");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string UserChoice = Console.ReadLine();


            Console.Clear();

            switch (UserChoice)
            {
                case "1":
                    NormalLogin();
                    break;

                case "2":
                    PremiumLogin();
                    break;

                case "3":
                    Console.WriteLine("About");
                    break;

                case "4":
                    Environment.Exit(0);

                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        public void NormalLogin()
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string pass = Console.ReadLine();

            Console.Clear();

            NormalUser nu = new NormalUser(name, email, pass);
            SubscriptionService subscriptionService = new SubscriptionService();
            subscriptionService.subscribe(nu);

            Console.WriteLine("1. Browse Media");
            Console.WriteLine("2. Switch to Premium Version");
            Console.WriteLine("3. Back");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string UserChoice = Console.ReadLine();


            Console.Clear();

            switch (UserChoice)
            {
                case "1":
                    BrowseMedia(nu);
                    break;

                case "2":
                    PremiumLogin();
                    break;

                case "3":
                    EnterDashboard();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }
        } 
        public void PremiumLogin()
        {
            Console.WriteLine("Enter Name:");
            string pname = Console.ReadLine();
            Console.WriteLine("Enter Email:");
            string pemail = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string ppass = Console.ReadLine();

            Console.Clear();


            PremiumUser pu = new PremiumUser(pname, pemail,ppass);
            SubscriptionService subscriptionService2 = new SubscriptionService();
            subscriptionService2.subscribe(pu);

            Console.WriteLine("1. Browse Media");
            Console.WriteLine("2. Switch to Normal Version");
            Console.WriteLine("3. Back");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string UserChoice1 = Console.ReadLine();


            Console.Clear();

            switch (UserChoice1)
            {
                case "1":
                    BrowseMedia(pu);
                    break;

                case "2":
                    NormalLogin();
                    break;

                case "3":
                    EnterDashboard();
                    break;
                case "4": 
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }


        public void BrowseMedia(User user)
        {
            Console.WriteLine("1. Movies");
            Console.WriteLine("2. Series");
            Console.WriteLine("3. Anime");
            Console.WriteLine("4. Back");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string UserChoice1 = Console.ReadLine();


            Console.Clear();

            switch (UserChoice1)
            {
                case "1":
                    MediaManager.printmedia(MediaList.movielist);
                    break;

                case "2":
                    MediaManager.printmedia(MediaList.seriesList);
                    break;

                case "3":
                    Console.WriteLine("Not Added Yet!");
                    BrowseMedia(user);
                    break;
                case "4":
                    Console.Clear();
                    EnterDashboard();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;


            }

            Console.Write("Enter your choice: ");
            string UserChoice2 = Console.ReadLine();

            int Choice = int.Parse(UserChoice2);

            if(UserChoice2 != "0" || UserChoice2 != "x")
            {
                Console.Clear();
                
                if(UserChoice1 == "1")
                {
                    Movie = MediaList.movielist[Choice-1];
                    mainInterface(user, Movie);
                }
                if(UserChoice1 == "2")
                {
                    Series = MediaList.seriesList[Choice-1];
                    mainInterface(user, Series);
                }


            }

        }

        public void mainInterface(User user, IMedia media)
        {
            Console.WriteLine("1. Watch");
            Console.WriteLine("2. Download");
            Console.WriteLine("3. Review");
            Console.WriteLine("4. Details");
            Console.WriteLine("5. Back");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            string UserChoice1 = Console.ReadLine();


            Console.Clear();

            switch (UserChoice1)
            {
                case "1":
                    WatchInterface(user);
                    break;

                case "2":
                    DownloadInterface(user);
                    break;

                case "3":
                    Console.WriteLine("Not added yet!");
                    mainInterface(user, media);

                    break;
                case "4":
                    MediaManager.GetDetails(media);
                    Console.ReadKey();
                    Console.Clear();
                    BrowseMedia(user);
                    break;
                case "5":
                    BrowseMedia(user);
                    break;
                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;


            }
        }

        public void WatchInterface(User user)
        {
            Console.WriteLine("1. Play");
            Console.WriteLine("2. Pause");
            Console.WriteLine("3. Stop");
            Console.WriteLine("4. Return");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string UserChoice1 = Console.ReadLine();


            Console.Clear();

            switch (UserChoice1)
            {
                case "1":
                    Console.WriteLine("Media Started.");
                    Console.Clear();
                    WatchInterface(user);
                    break;

                case "2":
                    Console.WriteLine("Media Paused.");
                    Console.Clear();
                    WatchInterface(user);
                    break;

                case "3":
                    Console.WriteLine("Media Stopped.");
                    Console.Clear();
                    WatchInterface(user);
                    break;
                case "4":
                    BrowseMedia(user);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;


            }
        }

        public void DownloadInterface(User user)
        {
            Console.Clear();
            if (user is PremiumUser)
            {
                Console.WriteLine("Download Started.");
            }
            else
            {
                Console.WriteLine("Normal users can't download!");
            }
            Console.ReadKey();
            BrowseMedia(user);
        }
    }
}
