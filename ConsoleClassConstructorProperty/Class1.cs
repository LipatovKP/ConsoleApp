using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleClassConstructorProperty
{
    public class Person
    { 
        
        // Члены класса должны быть приватными
        //private string _name;

        // Авто свойство
        public string SecondName { get; set; }
        public string Name {get; set; }

        public string FullName
        {
            get
            {
                return SecondName + " " + Name;
            }
        }

        public string ShortName
        {
            get
            {
                // Интерполяция $
                return $"{SecondName} {Name.Substring(0,1)}.";
            }
        }

        //// Создаются методы доступа
        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }

        //    set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentNullException("Имя не может быть пустым");
        //        }
        //        _name = value;
        //    }
        //}

        // Создаются методы доступа(2)
        //public string GetName() 
        //{  
        //    return _name; 
        //} 

        //public void SetName(string name)
        //{
        //    if (string.IsNullOrWhiteSpace(name))
        //    {
        //        throw new ArgumentNullException("Имя не может быть пустым");
        //    }

        //    _name = name;
        //}
                            
    }
}
