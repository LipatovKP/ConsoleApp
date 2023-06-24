using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleInterface
{
    internal class BMWSeven : ICar
    {
        

        void IObject.Create()
        {
            throw new NotImplementedException();
        }

        int ICar.Move(int distance)
        {
            int dist = distance / 100;
            Console.WriteLine(dist);
            return dist; 
        }
    }
}
