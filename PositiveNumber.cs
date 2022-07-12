using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq_Task2
{
    internal class PositiveNumber
    {
        public static void findPositiveNumber() {
            int[] tempArray = {
                1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14  
            };

            var result = from number in tempArray
                         where number != 0 && number > 0
                         select number;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
