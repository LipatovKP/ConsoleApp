using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        enum Days
        {
            Monday, 
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {

            Console.WriteLine(Days.Monday);
            
            int[] array = new int[5];
            array[0] = 0;
            array[1] = 1;
            array[2] = 2;
            array[3] = 3;
            array[4] = 4;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            List<int> list = new List<int>
            {1,2,3,4,5 };
            // или
            /*
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            foreach (var lists in list)
            {
                Console.WriteLine(list);  
            }
            */
            
            

        }
    }

    
}
