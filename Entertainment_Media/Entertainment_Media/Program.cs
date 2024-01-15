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
            User user = new User("Sadman Labib", new NormalSubscription());

            
            
            Console.WriteLine("1. Browse Media");
            Console.WriteLine("2. Subscribe to Normal Plan");
            Console.WriteLine("3. Subscribe to Premium Plan");
            Console.WriteLine("4. Exit");

            Console.ReadKey();

        }

    }
}

