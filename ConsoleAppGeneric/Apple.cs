using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeneric
{
    public class Apple<T> : Product
    {
        public Apple(string name, int volume, int energy) : base(name, volume, energy)
        {

        }
    }
}
