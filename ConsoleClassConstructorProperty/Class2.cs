using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassConstructorProperty
{
    internal class Person2
    {
        public string SecondNa { get; private set; }
        public string Names { get; private set; }
        public int Age { get; private set; }
        
        // Конструктор класса с параметрами
        public Person2(string senderNa, string nams, int age)
        {
            // Проверка значений
            if (age < 0)
               {
                 throw new ArgumentNullException("Возраст меньше нуля.");
               }
            

            SecondNa = senderNa;
            Names = nams;
            Age = age;
        }
    }
}
