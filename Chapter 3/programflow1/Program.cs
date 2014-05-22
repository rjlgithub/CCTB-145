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

            myApp.IfStatementSample();     //Call and execute a method
            myApp.WhileStatementSamples(); //Call and execute a method
            myApp.ForStatementSample();    //Call and execute a method
            myApp.ListDivisibleBy(3);      //Call and execute a method
            int someNumber;
            Console.Write("Enter a small number between 2 and 20: ");
            someNumber = int.Parse(Console.ReadLine());
            myApp.ListDivisibleBy(someNumber);
            myApp.EnumSample(Color.Green);  //Pass in a leteral value from my enumeration

            Console.WriteLine("Goodbye.");
            Console.WriteLine("Press [enter] to exit...");
            Console.ReadLine();
        } //end of Main() method

        private void EnumSample(Color favoriteColor)
        {
            Console.WriteLine("Sample Enumeration...");

            switch (favoriteColor)
            {
                case Color.Red:
                    Console.WriteLine("Your color is red.");
                    break;
                case Color.Blue:
                    Console.WriteLine("Your color is blue.");
                    break;
                case Color.Green:
                    Console.WriteLine("Your color is green.");
                    break;
                default:
                    Console.WriteLine("You entered a differend color: ");
                    Console.WriteLine(favoriteColor);
                    break;
            }
        } 

        private void ListDivisibleBy(int divisor)
        {
            Console.WriteLine("List all the number from 1 to 100 that are evenly visible by " + divisor);
            for (int counter = 1; counter <= 100; counter++)
            {
                if (counter % divisor == 0)
                {
                    Console.Write(counter);
                    Console.Write(", ");
                }
            }
            Console.WriteLine(); //write a line-feed
        } //end of listDivisibleBy() method

        private void ForStatementSample()
        {
            Console.WriteLine("For Statement Samples...");
            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine("  " + counter);
            }
        }

        private void WhileStatementSamples()
        { 
            Console.WriteLine("While and Do-While Statement Samples...");

            int counter = 10;
            while (counter > 0)
            { //only enter loop while condition above is true
                Console.WriteLine("  " + counter);
                counter = counter - 1;
            }

            int age;
            do
            {
                Console.Write("Enter your age once more: ");
                age = int.Parse(Console.ReadLine());
            } while (age < 1 || age > 100);
            string message;
            message = string.Format("You are {0} years old!", age);
            Console.WriteLine(message);
        } //end of WhileStatementSamples() method

        public void IfStatementSample()
        {
            Console.WriteLine("If Statement Sample...");

            Console.Write("Enter your age: ");
            string stringAge = Console.ReadLine();   //Get the text typed by user
            int age = int.Parse(stringAge);          //Convert typed number to an int

            if (age >= 65)
            {
                Console.WriteLine("You are a senior.");
            }
            else if (age >= 18)
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
