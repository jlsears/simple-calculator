using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Computational
    {
        public static int Answer = 0;

        public static void Addition(int firstAgain, int secondAgain, int counter)
        {
            Answer = firstAgain + secondAgain;
            Console.WriteLine("= " + Answer);
            return;
            }

        public static void Subtraction(int firstAgain, int secondAgain, int counter)
        {
            Answer = firstAgain - secondAgain;
            Console.WriteLine("= " + Answer);
            return;
        }

        public static void Multiplication(int firstAgain, int secondAgain, int counter)
        {
            Answer = firstAgain * secondAgain;
            Console.WriteLine("= " + Answer);
            return;
        }

        public static void Division(int firstAgain, int secondAgain, int counter)
        {
            Answer = firstAgain / secondAgain;
            Console.WriteLine("= " + Answer);
            return;
        }

        public static void Remainder(int firstAgain, int secondAgain, int counter)
        {
            Answer = firstAgain % secondAgain;
            Console.WriteLine("= " + Answer);
            return;
        }
      }
    }


