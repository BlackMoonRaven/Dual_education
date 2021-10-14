using System;


namespace Task_4
{
    public class Car
    {
        private string name;
        private string color;
        private double price;

        const string CompanyName = "Skoda";

        public Car() { }
        public Car(string newName, string newColor, double newPrice) { name = newName; color = newColor; price = newPrice; }

        public void Input()
        {
            Console.Write("Input Skoda`s model: ");
            name = Console.ReadLine();
            Console.Write("Input Skoda`s color: ");
            color = Console.ReadLine();
            Console.Write("Input Skoda`s price: ");
            price = double.Parse(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Skoda`s model {name}");
            Console.WriteLine($"Car`s color {color}");
            Console.WriteLine($"Car price {price}");
        }

        public void ChangePrice(double x)
        {
            double reduses = price / 100 * x;
            price -= reduses;
            Console.WriteLine($"Skoda {name} price reduces by {reduses}\n New car price is {price}");
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Input();
            car1.Print();
            car1.ChangePrice(10);

            Car car2 = new Car();
            car2.Input();
            car2.Print();


            Car car3 = new Car();
            car3.Input();
            car3.Print();
        }
    }
}
