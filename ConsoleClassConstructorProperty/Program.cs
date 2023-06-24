using ConsoleClassConstructorProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOPClassConstructorProperty
{
    internal class Program
    {

        static void Main(string[] args)
        {
          
            Person2 person2 = new Person2("Lipatov","Saveliy", 6);

            Person person = new Person();
            person.Name = "Kirill";
            person.SecondName = "Lipatov";

            
            Console.WriteLine(person2.SecondNa +" "+ person2.Names + " "+ person2.Age + " " + "лет.");
            Console.WriteLine(person.FullName);
            Console.WriteLine(person.ShortName);

        }
    }
    
}
