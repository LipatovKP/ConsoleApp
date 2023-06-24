using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOopException
{
    internal class MyOwnException : Exception
    {
        public MyOwnException() : base("Это мое исключение")
        {
        
        }
        public MyOwnException(string message) : base(message)
        {
        
        }
    }
}
