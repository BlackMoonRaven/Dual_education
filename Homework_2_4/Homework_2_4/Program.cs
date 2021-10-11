using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_4
{
    struct Dog 
    {
        public string name;
        public string mark;
        public int age;

        public override string ToString()
        {
            return string.Format($"My {mark} name is {name} and he is {age} years old");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog;
            myDog.name = "King";
            myDog.mark = "Huskies";
            myDog.age = 2;

            Console.WriteLine(myDog);
        }
    }
}
