using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOopMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

             Console.WriteLine(Factorial(3));

            var person1 = new Person("Irina", "Lipatova");
            var person2 = new Person("Kirill", "Lipatov");

            for (var i = 0; i < 10; i++)
            {
                var position1 = person1.Run();
                Console.WriteLine(position1);  

                Console.WriteLine(person2.Run(4,5));
            }

            Console.WriteLine(new string( '-' ,20));

            PrintHello("Kirill", 31);
            var name = PrintHello("Saveliy", 6);
            Console.WriteLine(name);
        }
        // Рекурсия
        public static int Factorial(int value)
        {
            if ( value <= 1 )
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }

        // модификатор_доступа тип_метода или (void) имя_метода (тип_параметра1 параметр1, тип_параметра2 параметр2, ...)
        // return-обязательно
        // Вызов без экземпляра класса, метод должен быть STATIC
        public static int PrintHello(string name, int age)
        {
            Console.WriteLine($"Привет, {name}.Вам {age} лет");

            return 0;
        }
    }
}
