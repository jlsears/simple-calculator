﻿using System;
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
                    Environment.Exit(1);
                    return;
                case "exit":
                    Environment.Exit(1);
                    return;
                default:
                    break;
            }
        }
    }
}