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
            string reply = Console.ReadLine();
            Proceeding.Replying(reply);
            }

        public static void Subtraction(int firstAgain, int secondAgain, int counter)
        {
            Console.WriteLine("= " + (firstAgain - secondAgain));
            string reply = Console.ReadLine();
            Proceeding.Replying(reply);
        }

        public static void Multiplication(int firstAgain, int secondAgain, int counter)
        {
            Console.WriteLine("= " + (firstAgain * secondAgain));
            string reply = Console.ReadLine();
            Proceeding.Replying(reply);
        }

        public static void Division(int firstAgain, int secondAgain, int counter)
        {
            Console.WriteLine("= " + (firstAgain / secondAgain));
            string reply = Console.ReadLine();
            Proceeding.Replying(reply);
        }

        public static void Remainder(int firstAgain, int secondAgain, int counter)
        {
            Console.WriteLine("= " + (firstAgain % secondAgain));
            string reply = Console.ReadLine();
            Proceeding.Replying(reply);
        }
      }
    }


