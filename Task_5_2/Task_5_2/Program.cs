using System;
using System.Collections;

namespace Task_5_2
{
    class Program
    {
        static void out_(ArrayList myColl)
        {
            //Вивід на екран
            foreach (object i in myColl)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Список чисел
            ArrayList myColl = new ArrayList();
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"Input number {i+1}/10: ");
                myColl.Add(int.Parse(Console.ReadLine()));
            }
            out_(myColl);

            //Вивід індекса чисел "-10"
            for(int i = 0; i < 10; i++)
            {
                if((int)myColl[i] == -10)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            //Видалення елементів які більші за "20"
            for(int i = 0, j = 10; i < j; i++)
            {
                if((int)myColl[i] > 20)
                {
                    myColl.Remove(myColl[i]);
                    j--;
                    i--;
                }
            }
            out_(myColl);

            //Встівка чисел по індексу
            myColl.Insert(2, 1);
            myColl.Insert(8, -3);
            myColl.Insert(5, -4);
            out_(myColl);

            //Сортування
            myColl.Sort();
            out_(myColl);
        }
    }
}
