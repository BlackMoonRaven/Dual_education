using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of month(1-12): ");
            int numMonth = int.Parse(Console.ReadLine());
            string[] month = {"31", "28", "31", "30", "31", "30", "31", "31", "30", "31", "30", "31"};

            while(numMonth > 12 || numMonth < 1)
            {
                Console.Write("Input correct number of month(1-12): ");
                numMonth = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"You input {numMonth} it`s {month[numMonth-1]}");

        }
    }
}
