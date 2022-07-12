using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq_Task2
{
    internal class CountDistinct
    {

        public static void countDistinctNumber() {
            int[] arr = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };


            var n = from x in arr
                    group x by x into y
                    select y;

            Console.WriteLine("\nThe number and the frequency are : \n");
            foreach (var arrno in n)
            {
                Console.WriteLine("Number " + arrno.Key + " appears " + arrno.Count() + " times");
            }

            Console.ReadLine();
        }
        
    }
}
