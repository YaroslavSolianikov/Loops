using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, которая будет выводить на экран таблицу умножения на 3.
/// </summary>
namespace Loops_002
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                int res = i * 3;
                Console.WriteLine($"3*{i} = {res}");
            }
            Console.ReadKey();
        }
    }
}
