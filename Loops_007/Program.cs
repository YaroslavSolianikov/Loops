using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, в которой создайте две целочисленные переменные и задайте им некоторые значения.Применяя технику вложенных циклов, нарисуйте прямоугольник из 
/// звездочек. Используйте значения ранее созданных переменных для указания высоты и ширины прямоугольника
/// </summary>
namespace Loops_007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Height");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("enter width");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < h; i++)
            {
                for (int j = 1; j < w; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine(" *");
            }
            Console.ReadKey();
        }
    }
}
