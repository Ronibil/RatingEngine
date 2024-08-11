using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRating
{
    public static class ConsoleOutput
    {
        public static void ShowStartMessage()
        {
            Console.WriteLine("Insurance Rating System Starting...");
        }

        public static void ShowStartRating()
        {
            Console.WriteLine("Starting rate.");
            Console.WriteLine("Loading policy.");
        }

        public static void ShowCompleteRating()
        {
            Console.WriteLine("Rating completed.");
        }

        public static void ShowStartPolicyRating(string policyType)
        {
            Console.WriteLine($"Rating {policyType} policy...");
            Console.WriteLine("Validating policy.");
        }

        public static void ShowRating(decimal rating)
        {
            if (rating > 0)
            {
                Console.WriteLine($"Rating: {rating}");
            }
            else
            {
                Console.WriteLine("No rating produced.");
            }
        }
        


    }
}
