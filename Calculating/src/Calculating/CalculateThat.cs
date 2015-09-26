using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculating
{
    public static class CalculateThat
    {
        public static void Init()
        {
            int counter = 0;

            Console.Write("[" + counter + "]" + "> ");
            string desiredCalc = Console.ReadLine();
            Console.WriteLine("We're going to calculate " + desiredCalc);
            Console.ReadLine();            
        }
    }
}
