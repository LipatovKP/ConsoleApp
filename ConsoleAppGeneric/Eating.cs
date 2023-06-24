using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeneric
{
    public class Eating<T>//<T> Универсальный шаблон
        where T : Product
    {
        public int Volume { get; private set; }

        public void Add( T product) 
        {
            Volume += product.Volume * product.Energy;
        } 
    }
}
