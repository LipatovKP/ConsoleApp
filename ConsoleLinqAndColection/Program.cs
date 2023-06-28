using ConsoleLinqAndColection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLinqAndCollection
{
    internal class Program
    {

        static Random rnd = new Random();

        static void Main(string[] args)
        {
           
           var products = new List<Product>();

            for (var i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "Продукт-" + i,
                    Energy = rnd.Next(10, 12)
                };
                products.Add(product);
            }

            var result = from item in products 
                         where item.Energy < 200
                         orderby item.Energy
                         select item;

            var result2 = products.Where(item =>  item.Energy < 200 || item.Energy > 400);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------");
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }


            var selectCollection = products.Select(product => product.Energy);

            foreach (var item in selectCollection)
            {
                Console.WriteLine(item);
            }

            var orderbyCollection = products.OrderBy(product => product.Energy)
                                            .ThenByDescending(product => product.Name);

            foreach (var item in orderbyCollection)
            {
                Console.WriteLine(item);
            }

            var groupbyCollection = products.GroupBy(product => product.Energy);
            
            foreach (var group in groupbyCollection)
            {
                Console.WriteLine($"Ключ: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
                Console.WriteLine();
            }

            products.Reverse();
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(products.All(item => item.Energy == 10));
            Console.WriteLine(products.Any(item => item.Energy == 10));
            Console.WriteLine(products.Contains(products[5]));


            Console.ReadLine();

        }
    }
}
