using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOopOperator
{
    public class Apple : Product
    {
        // base вызов конструктора базового класса
        public Apple(string name, int calorie, int volume) : base(name, calorie, volume)
        {

        }

        public static Apple Add(Apple apple1, Apple apple2)
        {
            var calories = (int)Math.Round(((apple1.Calorie + apple2.Calorie) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", calories, volume);

            return apple;
        }

        // Переопределение оператора(знака) "+","-","/","*","%"... для сложения
        public static Apple operator + (Apple apple1, Apple apple2)
        {
            var calories = (int)Math.Round(((apple1.Calorie +  apple2.Calorie) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", calories, volume);

            return apple;
        }
    }
}
