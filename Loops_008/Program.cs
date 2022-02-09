using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, которая выводит на экран столько элементов ряда Фибоначчи, сколько указал пользователь.
/// Например, если на ввод поступило число 6, то вывод должен содержать шесть первых чисел ряда Фибоначчи: 1 2 3 5 8 13.
/// (Числа Фибоначчи - элементы числовой последовательности, в которой первые два числа равны либо 1 и 1, либо 0 и 1,
/// а каждое последующее число равно сумме двух предыдущих чисел, например 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89).
/// </summary>
namespace Loops_008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            int j = 1;
            int res = 0;
            for (int i = 0; i < num; i++) 
            {       
                j += res;
                res = j - res;
                Console.WriteLine(res);
            }
            Console.ReadKey();
        }
    }
}
