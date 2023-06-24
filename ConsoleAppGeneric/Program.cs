using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var eating = new Eating<Apple<int>>();
            
            // <int,decimal> в место <T>
            //var apple = new Product<int>( "Яблоко", 100, 100 );
            //var banana = new Product<decimal>("Банан", 10.1M , 1100);
        }
    }
}
