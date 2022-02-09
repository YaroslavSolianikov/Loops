using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, в которой даны натуральные числа от 20 до 50. Вывести на консоль те из них, которые делятся на 3, но не делятся на 5.
/// </summary>
namespace Loops_003
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.Write($" {i}");
                }
            }
            Console.ReadKey();
        }
    }
}
