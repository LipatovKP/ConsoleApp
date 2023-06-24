using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterface
{
    // Интерфейсы имплементируются многократно
    internal class LadaSeven : ICar, IDisposable
    {
        public void Dispose()
        {
            
        }

        void IObject.Create()
        {
            throw new NotImplementedException();
        }

        // Реализация интерфейса
        int ICar.Move(int distance)
        {
            return distance / 40;
        }
    }
}
