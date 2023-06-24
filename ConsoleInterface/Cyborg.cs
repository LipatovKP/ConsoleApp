using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterface
{
    internal class Cyborg : ICar, IPerson
    {
        void IObject.Create()
        {
            throw new NotImplementedException();
        }

        int ICar.Move(int distance)
        {
            int dist = distance / 100;
            Console.WriteLine(dist);
            return dist; ;
        }

        int IPerson.Move(int distance)
        {
            int dist = distance / 5;
            Console.WriteLine(dist);
            return dist;
        }
    }
}
