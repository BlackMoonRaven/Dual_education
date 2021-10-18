using System;

namespace Homework_4
{
    public class Person
    {
        public string name { get; set; }
        public DateTime birthYear { get; set; }
        private int age;


        public Person() { }
        public Person(string newName, DateTime newBirthYear) { name = newName; birthYear = newBirthYear; }

        //Вираховування років
        public void Age()
        {
            age = DateTime.Now.Year - birthYear.Year;
            Console.WriteLine($"{name} has {age} years");
        }

        //Ввід інформації 
        public void Input()
        {
            Console.Write($"Input person`s name: ");
            name = Console.ReadLine();
            Console.Write($"Input {name} birthday year: ");
            birthYear = DateTime.Parse(Console.ReadLine());
        }

        //Заміна імені 
        public void ChangeName()
        {
            Console.Write($"You wont to change name {name} on: ");
            name = Console.ReadLine();
            Console.Write($"You change name on {name}");
        }

        //Вивід
        public void Output()
        {
            name.ToString();
            birthYear.ToString();
        }

        //Перевірка, чи людині 16 років або менше
        //Якщо так, то заміна її імені на "Very young"
        public void Check()
        {
            if(age <= 16)
            {
                name = "Very young";
            }
        }
        
        //Перегрузка оператора ==
        public static bool operator == (Person first, Person second)
        {
            return first.name == second.name;
        }
        //Перегрузка оператора !=
        public static bool operator !=(Person first, Person second)
        {
            return !(first.name == second.name);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            //Масив класу Person
            Person[] people = new Person[6];
            
            //Присвоєння об'єктам їх значень через консоль
            for(int i = 0; i < 6; i++)
            {
                people[i] = new Person();
                people[i].Input();
            }

            //Вирахування років
            //Вивід даних про об'єкти на екран
            for (int i = 0; i < 6; i++)
            {
                people[i].Age();
                people[i].Output();
            }

            //Перейменування осіб яким 16 або менше
            //Вивід даних про об'єкти на екран
            for (int i = 0; i < 6; i++)
            {
                people[i].Check();
                people[i].Output();
            }

            //Цикд для перевірки на одноіменність
            for (int i = 0; i < 6; i++)
            {
                //Запобігання виходу за межі масиву обєктів типу Person
                if(i == 4)
                {
                    if (people[i] == people[i+1])
                    {
                        Console.WriteLine($"Person {i + 1} and {i + 2} have same names and it`s name {people[i]}");
                    }
                    break;
                }

                //Перевірка на одноіменність 
                for (int j = i+1; j < 6; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"Person {i + 1} and {j + 1} have the same names and it`s name {people[i]}");
                    }
                }      
            }
        }
    }
}
