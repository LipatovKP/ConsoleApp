using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//public // открытый или публичный класс
//internal // открытый в пределах проэкта
//protected // защищенный класс
//private // закрытый класс
namespace ConsoleOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Firstname = "Kirill";
            person.Lastname = "Lipatov";

            Person person1 = new Person();
            person1.Firstname = "Saveliy";
            person1.Lastname = "Kirillovith";

            var doctor = new Doctor();
            doctor.Firstname = person.Firstname;
            doctor.Lastname = person.Lastname;
            doctor.Specialization = "JoON";

            Console.WriteLine(doctor.Firstname);
            Console.WriteLine(doctor.Lastname);
            Console.WriteLine(doctor.Specialization);
            
            Person person2 = doctor;
            Doctor doctor1 = (Doctor)person2;



        }
    }
}
