﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec19Exception.ex
{
    enum Season { summer = 12, rainy = 15, winter }
    enum Months { jan, feb, march = 25 }
    enum weekdays { mon, tues, wed }

    internal class Program
    {
        static void Main(string[] args)
            {
                Season s1 = Season.summer;
                Console.WriteLine(s1);
                Console.WriteLine(Season.winter);
                //type cast
                int n1 = (int)Season.winter;
                Console.WriteLine(n1);

            }
        }
    }

