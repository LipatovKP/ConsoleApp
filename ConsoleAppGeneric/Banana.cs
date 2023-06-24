using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeneric
{
    public class Banana<T> : Product
    {
        public Banana(string name, int volume,  int energy) : base(name, volume, energy)
        {
        }
    }
}
