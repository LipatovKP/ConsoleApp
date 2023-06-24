using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefOut
{
    internal class Program : ClassOut
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            //int area;
            //int perimeter;
            int number1;
            int number = 5;
            Console.WriteLine($"Число до метода Increment: {number}");
            // модификатор ref указывается как перед параметром при объявлении метода,
            // так и при вызове метода перед аргументом, который передается параметру
            Increment(ref number);
            Console.WriteLine($"Число после метода Increment: {number}");
            // Выходные параметры. Модификатор out
            Sum(10, 15, out number1);
            Console.WriteLine(number1);
            // Мы можем вернуть из метода не одно значение, а несколько
            GetRectangleData(10, 20, out int area, out int perimetr);
            Console.WriteLine($"Площадь прямоугольника: {area}");       // 200
            Console.WriteLine($"Периметр прямоугольника: {perimetr}");   // 60
            // Массив параметров и ключевое слово params
            Sum(nums);
            Sum(1, 2, 3, 4);
            Sum(1, 2, 3);
            Sum();



        }

        static void Increment(ref int n)
        {
            n++;
            Console.WriteLine($"Число в методе Increment: {n}");
        }
    }
    

    
}
