using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, которая поможет первокласнику Пети, у которого m рублей .
/// Мороженое стоит k рублей.Петя решил наесться досыта мороженого, для этого он покупал по одному мороженому и съедал его до тех пор, пока ему хватало денег.
/// Как Пете узнать, сколько денег останется у него в конце концов?
/// учтите, что петя делить еще не умеет, а умеет только вычитать и складывать. сколько мороженых он может съесть?.
/// </summary>
namespace Loops_006
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Petya's money: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Price: ");
            int pr = int.Parse(Console.ReadLine());
            int counter = 0;
            int money = 0;
            for (int i = m; i >= pr; i-=pr)
            {
                counter++;
                money = i - pr;
                Console.Write($" {i}");  
            }
            Console.WriteLine($" Petya has {money} UAH now");
            Console.WriteLine($"Petya can buy {counter} ice creams");
            Console.ReadKey();
        }
    }
}
