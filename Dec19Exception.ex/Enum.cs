using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec19Exception.ex
{
    enum Seasons { summer = 12, rainy = 15, winter }
    enum Monthss { jan, feb, march = 25 }
    enum weekdayss { mon, tues, wed }
    internal class Enum
    {
        static void Main(string[] args)
        {
            Seasons s1 = Seasons.summer;
            Console.WriteLine(s1);
            Console.WriteLine(Seasons.winter);
            int n1 = (int)Seasons.winter;
            Console.WriteLine(n1);
        }
    }
}


        
    

