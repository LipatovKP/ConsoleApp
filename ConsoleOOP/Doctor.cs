using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOOP
{
    // Наследование возможно только от одношо класса!!
    public class Doctor : Person
    {
        public string Specialization;

        void money()
        {
            var doctor = new Doctor();
            doctor.Money = 135M;
        }

    }
}
