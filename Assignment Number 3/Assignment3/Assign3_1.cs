using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Assign3_1
    {
        public static void assignRun()
        {
            int vNum;
            for (vNum = 0; vNum < 1 || vNum > 100; )
            {
                Console.Write("Please enter a number between 1 and 100: ");
                vNum = int.Parse(Console.ReadLine());
                if (vNum < 1 || vNum > 100)
                {
                    Console.WriteLine("The number you entered is not valid!");
                }  //end if (vNum < 1 || vNum > 100)
            }  // endfor (int vNum = 0; vNum < 1 || vNum > 100; )

            int vTot = 0;
            for (int addNum = 1; addNum <= vNum; addNum++)
            {
                if (IsEvenNumber(addNum))
                {
                    Console.Write("  Running Total -> " + vTot + " + " + addNum);
                    vTot = vTot + addNum;
                    Console.WriteLine(" = " + vTot);
                } //end if (IsEvenNumber(addNum))

            } //end for (int addNum = 1; addNum <= vNum; addNum++)

            Console.WriteLine("GRAND TOTAL of all even numbers between 1 and " + vNum + " is " + vTot);

        }  //end private void assign31()

        static public bool IsEvenNumber(int intNumber)
        {
            return intNumber % 2 == 0;
        }  //end static public bool IsEvenNumber(int intNumber)

    }
}
