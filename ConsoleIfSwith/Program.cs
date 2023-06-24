using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIfSwith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Введите сумму вклада: ");
            double sum = Convert.ToDouble(Console.ReadLine());
             
            if (sum < 100)
            {
                sum += sum * 0.05;
            }
            else if (sum <= 200)
            {
                sum += sum * 0.07;
            }
            else
            {
                sum += sum * 0.1;
            }
            Console.WriteLine($"Сумму вклада после начисления процентов: {sum}");
 
            Console.ReadKey();
            */

            // && || ! 
            // И ИЛИ НЕ
            while (true)
            { 
              int input = int.Parse(Console.ReadLine());
                if (input > 10)
                {
                Console.WriteLine("больше");                   
                }
                else
                {
                Console.WriteLine("Меньше"); 
                }
            }

            /*
            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine("Введите номер операции: 1.Сложение  2.Вычитание  3.Умножение");
 
            int operation = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (operation)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"Результат операции {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"Результат операции {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"Результат операции {result}");
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }
            Console.ReadKey();
            }
            */
        }
    }
}
