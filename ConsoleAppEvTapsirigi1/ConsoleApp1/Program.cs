using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reqem daxil edin");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num > 0)
            {

                if (num % 2 == 0)
                {
                    sum += num % 10;
                 }
                num = (num / 10);

            }

            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
    }

