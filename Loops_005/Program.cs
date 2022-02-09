using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, где пользователь вводит любое целое положительное число. А программа суммирует все числа от 1 до введенного пользователем числа.
/// </summary>
namespace Loops_005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = int.Parse(Console.ReadLine());
            int res = 0;
            for (int i = 1; i <= a; i++)
            {
                res += i;
            }
            Console.Write($"Sum = {res}");
            Console.ReadKey();
        }
    }
}
