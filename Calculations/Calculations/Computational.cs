using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Computational
    {
        public static void Addition(int firstAgain, int secondAgain, int counter)
        {
            Console.WriteLine("= " + (firstAgain + secondAgain));
            return;
            }

        public static void Subtraction(int firstAgain, int secondAgain, int counter)
        {
            Console.WriteLine("= " + (firstAgain - secondAgain));
            return;
        }

        public static void Multiplication(int firstAgain, int secondAgain, int counter)
        {
            Console.WriteLine("= " + (firstAgain * secondAgain));
            return;
        }

        public static void Division(int firstAgain, int secondAgain, int counter)
        {
            Console.WriteLine("= " + (firstAgain / secondAgain));
            return;
        }

        public static void Remainder(int firstAgain, int secondAgain, int counter)
        {
            Console.WriteLine("= " + (firstAgain % secondAgain));
            return;
        }
      }
    }


