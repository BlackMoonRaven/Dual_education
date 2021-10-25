using System;
using System.Collections.Generic;

namespace Task_5_1
{

    //Інтерфейс
    interface IFlyable
    {
        void Fly();
    }

    //Клас пташка
    public class Bird : IFlyable
    {
        public string name { get; set; }
        public bool canFly { get; set; }

        public void Fly()
        {
            if (canFly)
            {
                Console.WriteLine($"The {name} can fly");
            }
            else
            {
                Console.WriteLine($"The {name} cannot fly");
            }
        }
    }

    //клас літак
    public class Plane : IFlyable
    {
        public string mark { get; set; }
        public int highFly { get; set; }

        public void Fly()
        {
            Console.WriteLine($"The {mark} can fly up to {highFly} km");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Заповнення списку
            List<IFlyable> list = new List<IFlyable>
            {
                new Bird {name = "Falcon", canFly = true},
                new Bird {name = "Penguin", canFly = false},
                new Bird {name = "Eagle", canFly = true},

                new Plane {mark = "F-4", highFly = 30},
                new Plane {mark = "p-10", highFly = 7},
                new Plane {mark = "SR-71", highFly = 25}
            };

            //Вивід
            foreach (IFlyable info in list)
            {
                info.Fly();
            }

        }            
    }
}



