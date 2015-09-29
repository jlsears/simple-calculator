﻿using System;
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
                    Console.WriteLine("We're going to calculate " + desiredCalc);


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

                    Console.WriteLine("We have " + firstPart + " and " + secondPart + " now.");


                    var foundIt = desiredCalc.IndexOfAny(theDelimiters);
                    var ourComputation = desiredCalc[foundIt];
                    Console.WriteLine("Here's our delimiter: " + ourComputation);

                    switch (ourComputation)
                    {
                        case '+':
                            Console.WriteLine("= " + (firstAgain + secondAgain));
                            counter = counter + 1;
                            string reply = Console.ReadLine();
                            switch(reply)
                            {
                                case "quit":
                                    return;
                                case "exit":
                                    return;
                                default:
                                    break;
                            }

                            break;
                        case '-':
                            Console.WriteLine("= " + (firstAgain - secondAgain));
                            Console.ReadLine();
                            break;
                        case '*':
                            Console.WriteLine("= " + (firstAgain * secondAgain));
                            Console.ReadLine();
                            break;
                        case '/':
                            Console.WriteLine("= " + (firstAgain / secondAgain));
                            Console.ReadLine();
                            break;
                        case '%':
                            Console.WriteLine("= " + (firstAgain % secondAgain));
                            Console.ReadLine();
                            break;
                    }

                    Console.ReadLine();
                }
                catch
                {
                    //something here
                }
            }
            //Init();
        }
    }
}
