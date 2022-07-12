using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq_Task2
{
    internal class Multipleof4and6
    {

        public void checkMultiple() {
            List<int> mixedNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            Console.WriteLine("\nThe members of the list are : ");
            foreach (var lstnum in mixedNumbers)
            {
                Console.WriteLine(lstnum + " ");
            }

            mixedNumbers.Sort();

            Console.Write("The numbers divisible by 4 or 6 from the list are: \n");

            foreach (int n in mixedNumbers)
            {
                if(n%4 == 0 || n%6  == 0)
                    Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
