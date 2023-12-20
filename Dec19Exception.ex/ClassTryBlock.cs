using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec19Exception.ex
{
    public class ClassTryBlock
    {
        public static void Fun1()
        {
            try
            {
                int res, n1, n2;
                n1 = 25;
                n2 = 0;
                res = n1 / n2;
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                Console.WriteLine("may be we are dividing by 0");
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("we are in finally");
            }
        }
        static void Main(string[] args)
        {
            Fun1();
            Console.ReadLine();
        }

            
        }
       
    }

