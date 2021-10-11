using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            string max = (a > b && a > c) ? $"max is {a}" : (b > a && a > c) ? $"max is {b}" : $"max is {c}";
            string min = (a < b && a < c) ? $"min is {a}" : (b < a && a < c) ? $"min is {b}" : $"min is {c}";

            Console.WriteLine($"{max}\n{min}");
        }
    }
}
