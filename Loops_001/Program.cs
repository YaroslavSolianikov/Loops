using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, которая будет выводить на экран числа от 1 до 5. Написать три варианта реализации(while, do...while, for).
/// </summary>
namespace Loops_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-(While),2-(do...while),3-(for)");
            int a = int.Parse(Console.ReadLine());
            int num = 0;

            switch (a)
            {
                case 1:
                    {
                        while( num < 5)
                        {
                            num++;
                            Console.Write($"\t { num}");
                        }
                        break;
                    }
                case 2:
                    {
                        do
                        {
                            num++;
                            Console.Write($"\t { num}");
                        }
                        while (num < 5);
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            num++;
                            Console.Write($"\t { num}");
                        }
                        break;
                    }
                default:
                    Console.WriteLine("incorrect input");
                    break;
            }
            Console.ReadKey();
        }
    }
}
