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
            var theirReply = true;

            while (theirReply)
            {

                try
                {
                    var theDelimiters = new[] { '+', '-', '*', '/', '%' };
                    var prompt = "[" + counter + "]" + "> ";

                    Console.Write(prompt);
                    string desiredCalc = Console.ReadLine();
                    //Console.WriteLine("We're going to calculate " + desiredCalc);

                    switch (desiredCalc)
                    {

                        case "quit":
                            Console.WriteLine("See ya!");
                            Environment.Exit(1);
                            return;
                        case "exit":
                            Console.WriteLine("See ya!");
                            Environment.Exit(1);
                            return;

                        default:

                            string[] parsedInfo = desiredCalc.Split(theDelimiters);

                            string firstPart = "filler";
                            string secondPart = "filler";

                            foreach (string s in parsedInfo)
                            {
                                firstPart = parsedInfo[0];
                                secondPart = parsedInfo[1];
                            }

                            int firstAgain = Convert.ToInt32(firstPart);
                            int secondAgain = Convert.ToInt32(secondPart);

                            //Console.WriteLine("We have " + firstPart + " and " + secondPart + " now.");


                            var foundIt = desiredCalc.IndexOfAny(theDelimiters);
                            var ourComputation = desiredCalc[foundIt];
                            //Console.WriteLine("Here's our delimiter: " + ourComputation);

                            switch (ourComputation)
                            {
                                case '+':
                                    counter = counter + 1;
                                    Computational.Addition(firstAgain, secondAgain, counter);
                                    break;
                                case '-':
                                    counter = counter + 1;
                                    Computational.Subtraction(firstAgain, secondAgain, counter);
                                    break;
                                case '*':
                                    counter = counter + 1;
                                    Computational.Multiplication(firstAgain, secondAgain, counter);
                                    break;
                                case '/':
                                    counter = counter + 1;
                                    Computational.Division(firstAgain, secondAgain, counter);
                                    break;
                                case '%':
                                    counter = counter + 1;
                                    Computational.Remainder(firstAgain, secondAgain, counter);
                                    break;
                            }
                            break;
                    }
                    
                }
                catch
                {
                    //something here
                }                               
            }                    
        }
    }
}

