using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public static class Computational
    {
        public static void Addition(int firstAgain, int secondAgain, int counter)
        {
            Console.WriteLine("= " + (firstAgain + secondAgain));
            counter = counter + 1;
            string reply = Console.ReadLine();
            switch (reply)
            {
                case "quit":
                    return;
                case "exit":
                    return;
                default:
                    break;
            }
        }
    }
}
