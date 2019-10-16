using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEvTapsirigi1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reqem daxil edin");
            int num=int.Parse(Console.ReadLine());
            int mult = 1;

            while (num>0)
            {
                mult= mult* (num % 10);
                num = num / 10;
            }

            Console.WriteLine(mult);

            Console.ReadKey();
            }

        

        
    }
    }

