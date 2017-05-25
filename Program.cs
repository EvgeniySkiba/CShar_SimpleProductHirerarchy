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

            Container container = new Container();
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

            Console.WriteLine("Before sorting :");
            Console.WriteLine(container.ToString());

            Console.WriteLine("After sorting by name  :");
            container.Sort(true,"Name");
            Console.WriteLine(container.ToString());

            Console.WriteLine("After sorting by price  :");
            container.Sort(true, "Price");
            Console.WriteLine(container.ToString());

            Console.WriteLine("After removed the second element :");
            Console.WriteLine(container.ToString());

            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();

        }
    }
}
