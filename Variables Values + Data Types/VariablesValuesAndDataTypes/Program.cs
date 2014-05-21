using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesValuesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Order of operations - arithmetic operators...
            double result = 5 + 6 * 4 + 1;
            //              |   |   |   |
            //              |   \   /   |
            //              |    ___    |
            //              |     |     |
            //              \     /     |
            //               \   /      |
            //                ___       |
            //                 |        |
            //                  \      /
            //                   \    /
            //                     ___

            Console.WriteLine("The result of math is " + result);
            Console.WriteLine(" ");

            //What does casting really do??
            char singleDigit = '5';
            int simpleNumber = 25;
            //The result of casting...
            Console.WriteLine("Casting '5' ...");
            Console.WriteLine((int)singleDigit);
            Console.WriteLine("Casting 25 ...");
            Console.WriteLine((double)simpleNumber);
            Console.WriteLine(" ");

            //The result of converting...
            Console.WriteLine("Converting '5' ...");
            Console.WriteLine(Convert.ToInt32(singleDigit));
            Console.WriteLine("Converting 25 ...");
            Console.WriteLine(Convert.ToDouble(simpleNumber));
            Console.WriteLine(" ");
            //Alternat way of converting using the Parse method
            Console.WriteLine("Converting '5' using int.Parse()");
            //Console.WriteLine(int.Parse(singleDigit));           //can't parse args single char
            Console.WriteLine(int.Parse(singleDigit.ToString()));  //can parse a string
            Console.WriteLine("The value in the variable singleDigit is " + singleDigit.ToString());
            Console.WriteLine(" ");

            Console.WriteLine("Converting '5' after calling .ToString()...");
            Console.WriteLine(Convert.ToInt32(singleDigit.ToString()));
            Console.WriteLine(" ");

            Console.WriteLine((int)result);
            Console.WriteLine(" ");

            Console.WriteLine((int)30.5);
            Console.WriteLine(" ");


            //Variables of various data types, with valules


        }
    }
}
