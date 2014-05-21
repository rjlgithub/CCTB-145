using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Please input name: ");
            // Create some local variables
            string name;
            name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            int five = 5;
            int seven = 7;
            int total;
            total = five + seven;
            Console.WriteLine("5 + 7 is " + total);


            double price = 10.95;
            int quantity = 3;

            double totalPrice;
            totalPrice = price * quantity;

            Console.Write(price);
            Console.Write(" times ");
            Console.Write(quantity);
            Console.Write(" equals ");
            Console.WriteLine(totalPrice);
            Console.WriteLine("Computers do math...");

        }
    }
}
