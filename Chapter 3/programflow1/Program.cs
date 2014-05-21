using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programflow1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Write the code that will run the samples...
            Program myApp = new Program(); //Create an object based on this class

            myApp.IfStatementSample();     //Call (ie. execute) the method

            Console.WriteLine("Goodbye.");
        } //end of Main() method

        public void IfStatementSample()
        {
            Console.WriteLine("If Statement Sample...");

            Console.WriteLine("Enter your age: ");
            string stringAge = Console.ReadLine();   //Get the text typed by user
            int age = int.Parse(stringAge);          //Convert typed number to an int

            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult");
            }

        } //end of IfStatementSample() method

    } //end of Program class
} //end of namespace for this file's code
