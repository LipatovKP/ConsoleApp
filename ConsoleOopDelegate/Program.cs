using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOopDelegate
{
    //// Делегаты это пачка методов
    //// Делегат без аргументов
    //public delegate void MyDelegate();

    internal class Program
    {
        //// Делегат С аргументами
        //public delegate int ValueDelegate(int value);

        //// Шаблоны делегатов "Action" В место объявления
        //public Action<int> ActionDelegate;
        //// Тип делегата с Булевым значением и одним аргументом
        //public delegate bool Predicate<T>(T value);
        //// Должен возвращать значение
        //public delegate int Func(string value);

        
        //public event MyDelegate Event;
        //public event Action EventActio;
        
        
        static void Main(string[] args)
        {
            #region Delegate
            //MyDelegate myDelegate = Method1;
            //myDelegate += Method4;
            //myDelegate();

            //MyDelegate myDelegate2 = new MyDelegate(Method4);
            //myDelegate2 += Method4;
            //myDelegate2 -= Method4;

            //myDelegate2.Invoke();
            //MyDelegate myDelegate3 = myDelegate + myDelegate2;
            //myDelegate3.Invoke();

            //var valueDelegate = new ValueDelegate(MethodValue);
            //valueDelegate += MethodValue;
            //valueDelegate += MethodValue;
            //valueDelegate += MethodValue;
            //valueDelegate += MethodValue;
            //valueDelegate((new Random()).Next(10,51));
            //// Делегат Action
            //Action actionDelegate = Method1;
            //actionDelegate();

            //Predicate<int> predicate;

            //Func<int, int> func = MethodValue;            
            //if (func != null)
            //{
            //    func(7);
            //}
            //// Упрощенная форма
            //// func?.Invoke(7);
            #endregion


            Person person = new Person();
            person.Name = "Kirill";
            person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;
            person.TakeTime(DateTime.Parse("17.06.2023 7:59:01"));
            person.TakeTime(DateTime.Parse("17.06.2023 21:59:01"));

        }

        private static void Person_DoWork(object sender, EventArgs e)
        {
            if (sender is Person)
            {
                Console.WriteLine($"{((Person)sender).Name} Работает!!!");
            }
            
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("Пошел спать");

        }















        //public static void Method1()
        //{
        //    Console.WriteLine("Method1");
        //}
        //public static int MethodValue(int value)
        //{
        //    Console.WriteLine($"MethodValue: {value}");
        //    return value;
        //}
        //public static void Method3(int i)
        //{
        //    Console.WriteLine("Method3");
        //}
        //public static void Method4()
        //{
        //    Console.WriteLine("Method4");
        //}

    }
}
