using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeneric
{
    public class Product// <T> Универсальный шаблон
    {
        public string Name { get; set; }
        public int Volume { get; set; }
        public int Energy { get; set; }

        public Product(string name, int volume, int energy) 
        { 
            // TODO: Проверить входные параметры

            Name = name;
            Volume = volume;
            Energy = energy;
        }

    }
}
