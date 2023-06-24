using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOopMethod
{
    internal class Person
    {
        public string SecondName { get; set; }
        public string FirstName { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public Person(string secondName, string firstName) 
        {
            SecondName = secondName;
            FirstName = firstName;

            X = 0;
            Y = 0;
        }

        public string Run()
        {
            var rnd = new Random();

            X += rnd.Next(-2, 2);
            Y += rnd.Next(-2, 2);

            return $"{SecondName} {FirstName} ({X}, {Y})";
        }
        // Перегрузка методов
        public string Run(int x, int y) 
        {
            X += x;
            Y += y;

            return $"{SecondName} {FirstName} ({X}, {Y})";
        }

        
        public string Run(Person x) 
        {
            

            return $"{SecondName} {FirstName} ({X}, {Y})";
        }

    }
}
