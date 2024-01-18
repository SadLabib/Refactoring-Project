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

        IWatch watch { get; set; }

        public Dashboard(MediaList mediaList, MediaManager mediaManager, IWatch watch)
        {
            MediaList = mediaList;
            MediaManager = mediaManager;
            this.watch = watch;
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
                    BrowseMedia();
                    break;

                case "2":
                    PremiumLogin();
                    break;

                case "3":
                    Console.WriteLine("About");
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
                    BrowseMedia();
                    break;

                case "2":
                    NormalLogin();
                    break;

                case "3":
                    Console.WriteLine("About");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }


        public void BrowseMedia()
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
                    break;
                case "4":
                    Console.WriteLine("Not Added Yet!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;


            }

            Console.Write("Enter your choice: ");
            string UserChoice2 = Console.ReadLine();

            if(UserChoice2 != "0" || UserChoice2 != "x")
            {
                Console.Clear();
                mainInterface();
            }

        }

        public void mainInterface()
        {
            Console.WriteLine("1. Watch");
            Console.WriteLine("2. Download");
            Console.WriteLine("3. Review");
            Console.WriteLine("4. Details");
            Console.WriteLine("5. Back");
            Console.WriteLine("6. Exit");
        }
    }
}
