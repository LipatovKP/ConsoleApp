using Newtonsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleOopException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            while (true)
            {
                var input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {

                    Console.WriteLine($"Интовый {result}");
                    break;
                }
                else
                {
                    Console.WriteLine("Не корректно");
                }
            }

            Console.WriteLine(result);


            int i = 6;

            try
            {
                //int i = 5;
                //int j = i / 1;
                //Console.WriteLine(j);
               
                //int a = 200000000;
                //int b = 200000000;
                //int c = checked(a * b);
                //Console.WriteLine(c);
                //throw new DivideByZeroException();

                throw new MyOwnException();
                
            }
            catch(MyOwnException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex) when (i == 5)
            {
                Console.WriteLine("Деление на ноль");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Какое то исключение");               
            }
            finally 
            {
                Console.WriteLine("Работа завершена");
                Console.ReadLine();
            }

            
        }
    }
}
