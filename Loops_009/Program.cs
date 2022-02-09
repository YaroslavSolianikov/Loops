using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, в которой запросите пользователя ввести два числа A и B (A<B), если (A>B выведите соответствующее предупреждение)
/// и выведите суму всех чисел расположенных между данными числами на экран.
/// Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами.
/// </summary>
namespace Loops_009
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2 = int.Parse(Console.ReadLine());
            int res = 0;
            if (num1 < num2)
            {
                for (int i = num1; i < num2; i++)
                {
                    res += i;
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine($"sum of all {res}");
            }
            else
            {
                Console.WriteLine("incorrect input");
            }
            Console.ReadKey();
        }
    }
}
