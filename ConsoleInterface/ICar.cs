using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInterface
{
    internal interface ICar : IObject
    {
        /// <summary>
        /// Выполнить перемещение
        /// </summary>
        /// <param name="distance"> Расстояние </param>
        /// <returns> Время движения </returns>
        int Move(int distance);
    }
}
