using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEvTapsirigi3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reqem daxil edin");
            int num = int.Parse(Console.ReadLine());
            int count = 0;




            while (num>0)
            {
                 if(num% 10==2)
                {
                    count++;

                }

                num = num / 10;
            }

            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
