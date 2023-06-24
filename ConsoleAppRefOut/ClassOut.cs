using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefOut
{
    internal class ClassOut
    {

        public static void Sum(int x, int y, out int result)
        {
            result = x + y;
            Console.WriteLine(result);
        }

        public static void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
        {
            rectArea = width * height;       // площадь прямоугольника - произведение ширины на высоту
            rectPerimetr = (width + height) * 2; // периметр прямоугольника - сумма длин всех сторон  
        }

        public static void Sum(params int[] numbers)
        {
            int result = 0;
            foreach (var item in numbers)
            {
                result += item;
            }
            Console.WriteLine(result);

        }
       //факториал
        int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
        //Фибоначчи
        int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
        //Фибоначчи2
        static int Fibonachi2(int n)
        {
            int result = 0;
            int b = 1;
            int tmp;

            for (int i = 0; i < n; i++)
            {
                tmp = result;
                result = b;
                b += tmp;
            }

            return result;
        }
    }
}       

        
