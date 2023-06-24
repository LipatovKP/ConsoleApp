using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOopOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple appleRad = new Apple("Красное яблоко", 100, 100);
            Apple appleGreen = new Apple("Зеленое яблоко", 90, 110);
            
            var sumApple = Apple.Add(appleRad, appleGreen);
            var sumApple1 = appleRad + appleGreen;

            Console.WriteLine(appleRad);
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(appleGreen);
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(sumApple);
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(sumApple1);
        }
    }
}
