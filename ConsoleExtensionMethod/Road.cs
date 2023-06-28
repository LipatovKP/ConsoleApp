using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExtensionMethod
{
    public sealed class Road
    {
        public string Number { get; set; }

        public int Lenght { get; set; }

        public override string ToString()
        {
            return $"Дорога {Number} общей протяжённостью {Lenght}";
        }
    }
}
