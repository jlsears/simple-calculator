using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public static class Proceeding
    {
        public static void Replying(string reply)
        {
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