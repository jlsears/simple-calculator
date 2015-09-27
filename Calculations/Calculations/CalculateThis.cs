using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public static class CalculateThis
    {
        public static void Init()
        {
            int counter = 0;
            var theDelimiters = new[] { '+', '-', '*', '/', '%' };
            var prompt = "[" + counter + "]" + "> ";

            Console.Write(prompt);
            string desiredCalc = Console.ReadLine();
            Console.WriteLine("We're going to calculate " + desiredCalc);
           

            string[] parsedInfo = desiredCalc.Split(theDelimiters);

            string firstPart = "filler";
            string secondPart = "filler";
             
            foreach (string s in parsedInfo)
            {
                firstPart = parsedInfo[0];
                secondPart = parsedInfo[1];
            }

            Console.WriteLine("We have " + firstPart + " and " + secondPart + " now.");


            var foundIt = desiredCalc.IndexOfAny(theDelimiters);
            var ourComputation = desiredCalc[foundIt];
            Console.WriteLine("Here's our delimiter: " + ourComputation);

            Console.ReadLine();
        }
    }
}
