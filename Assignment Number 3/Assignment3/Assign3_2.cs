using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Assign3_2
    {
        public static void assignRun()
        {
            int vCount1 = 0;
            int vCount2 = 0;

            for (int outerLoop = 5; outerLoop > 0; outerLoop--)
            {
                for (int innerLoop = 1; innerLoop <= 3; innerLoop++)
                {
                    int result = outerLoop * innerLoop;
                    if (result > 5)
                    {
                        vCount1++;
                    }
                    if (result < 5)
                    {
                        vCount2++;
                    }
                    if (result != 5)
                    {
                        Console.WriteLine(result);
                    }
                }  //end for (int innerLoop = 1; innerLoop <= 3; innerLoop++)
            }  //end for (int outerLoop = 5; outerLoop > 0; outerLoop--)

            Console.WriteLine(vCount1 + " numbers are less than 5.");
            Console.WriteLine(vCount2 + " numbers are greater than 5.");

        }  //end private void assign32()
    }
}
