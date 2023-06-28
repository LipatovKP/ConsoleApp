using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExtensionMethod
{
    internal class Program
    {
        // Методы расширения
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                //var isEven = IsEven(result);
                // метод расширения
                //result.IsEven();
                    
               if (result.IsEven())
               {
                   Console.WriteLine($"{result} - Четное.");
               }
               else
               {
                   Console.WriteLine($"{result} - Нечетное.");
               }

                int h = 182;
                Console.WriteLine(h.IsDividedBy(7)); 

                
                
            }
            else
            {
                Console.WriteLine("Это не число.");
            }

             Console.ReadLine();

            var roads = new List<Road>();
            for (int i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreateRandomRoad(1000, 10000);
                roads.Add(road);
            }

            var roadsName = roads.ConvertToString();
            Console.WriteLine(roadsName);

            Console.ReadLine();
                
        }
    }
}

        
    

