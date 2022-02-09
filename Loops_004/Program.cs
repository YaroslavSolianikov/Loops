using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, которая будет рассчитывать сумму вклада в банк.
/// Процентную ставку, сумму и срок на которой положили вклад, должен вводить пользователь с клавиатуры.
/// </summary>
namespace Loops_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter %:");
            decimal s = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter deposit:");
            decimal x = decimal.Parse(Console.ReadLine());
            Console.WriteLine("enter mounths:");
            decimal m = decimal.Parse(Console.ReadLine());

            for (int i = 1; i < m; i++)
            {
                decimal res = x * (decimal)Math.Pow((double)(1 + (s / (12 * 100))),i);
                Console.WriteLine(Math.Round(res,2));             
            }
            Console.ReadKey();
        }
    }
}
