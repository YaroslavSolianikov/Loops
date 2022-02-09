using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, которая будет складывать, вычитать, умножать или делить два числа.
/// Числа и знак операции вводятся пользователем. После выполнения вычисления программа не должна завершаться, а должна запрашивать новые данные для вычислений.
/// Завершение программы должно выполняться при вводе символа '0' в качестве знака операции. Если пользователь вводит неверный знак (не '0', '+', '-', '*', '/'), 
/// то программа должна сообщать ему об ошибке и снова запрашивать знак операции. 
/// Также сообщать пользователю о невозможности деления на ноль, если он ввел 0 в качестве делителя.
/// </summary>
namespace Loops_010
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter sign (+,-,*,/, 0-exit)");
                char s = char.Parse(Console.ReadLine());
                if (s == '0')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Enter 1st num");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter 2st num");
                    double b = double.Parse(Console.ReadLine());
                    switch (s)
                    {
                        case '+':
                            Console.WriteLine(a + b);
                            break;
                        case '-':
                            Console.WriteLine(a - b);
                            break;
                        case '*':
                            Console.WriteLine(a * b);
                            break;
                        case '/':
                            if (b != 0)
                            {
                                Console.WriteLine(a / b);
                            }
                            else
                            {
                                Console.WriteLine("2th num cant be 0!");
                            }
                            break;
                        default:
                            Console.WriteLine("incorrect input");
                            break;
                    }
                }
            }
        }
    }
}
