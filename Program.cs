using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product();
            product.Name = "Book";
            product.Price = 12.32m;// m - because decimal 

            Container container = null;// new Container();

            // поймать сгенерированное нами исключение 
            try
            {
                //сгенерировать исключение 
                container = new Container(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // initialise container
            container = new Container(4);

            container.Add(product);

            product = new Product();
            product.Name = "Book141"; // simple name for demonstrate sorting 
            product.Price = 22.32m;
            container.Add(product);

            product = new Product();
            product.Name = "Book7";
            product.Price = 13.72m;
            container.Add(product);

            product = new Product();
            product.Name = "Book12";
            product.Price = 72.32m;
            container.Add(product);

            product = new Product();
            product.Name = "Book2";
            product.Price = 32.32m;
            container.Add(product);

            // exception - выход за пределы массива 
            product = new Product();
            product.Name = "Book17";
            product.Price = 32.32m;
            container.Add(product);

            Console.WriteLine("Before sorting :");
            Console.WriteLine(container.ToString());

            Console.WriteLine("After sorting  :");
            container.Sort();
            Console.WriteLine(container.ToString());

            try
            {
                // exception - выход за пределы массива 
                container.deleteByIndex(10);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Incorrect index");
            }

            Console.WriteLine("After removed the second element :");
            Console.WriteLine(container.ToString());

            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();

        }
    }
}
