using System;
using System.Collections.Generic;
using System.Linq;
namespace arraysandlists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("test which question? ");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    task1();
                    break;

                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;

                case 4:
                    task3();
                    break;

                case 5:
                    task5();
                    break;
            }
            static void task1()
            {
                string[] userlist = new string[5];
                Console.WriteLine("please enter 5 names");
                for (int i = 0; i < 5; i++)
                {
                    userlist[i] = Console.ReadLine();
                }
                for (int i = 0; i < userlist.Length; i++)
                {
                    Console.WriteLine("hello {0}", userlist[i]);

                }
            }
            static void task2()
            {
                int[] numbers = { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };
                Console.WriteLine("total of numbers provided: {0}", numbers.Sum());
            }

            static void task3()
            {
                List<int> numbers = new List<int>();
                Console.WriteLine("Enter 5 numbers");
                for (int i = 0; i < 5; i++)
                {
                    numbers.Add(int.Parse(Console.ReadLine()));
                }
                Console.WriteLine("Enter another number");
                int imput = int.Parse(Console.ReadLine());
                int count = numbers.Count(a => a == imput);
                if (count == 0)
                {
                    Console.WriteLine("This number does not repeat");
                }
                else
                {
                    Console.WriteLine("This number repeats {0} time(s)", count);
                }

            }
            static void task5()
            {
                List<string> input = new List<string>();
                Console.WriteLine("Enter some words or type STOP to finish");
                int stop = 0;
                while (stop == 0)
                {
                    string userinput = Console.ReadLine();
                    if (userinput == "STOP")
                    {
                        stop = 1;
                    }
                    else
                    {
                        input.Add(userinput);
                    }
                }
                for (int i = (input.Count - 1) ; 0 <= i ; i--)
                {
                    Console.Write(input[i] + " ");
                }
            }

        }
    }
}