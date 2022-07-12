using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq_Task2
{
    internal class TopN
    {
        public static void getTopN()
        {

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            Console.WriteLine("\nThe members of the list are : ");
            foreach (var lstnum in list)
            {
                Console.WriteLine(lstnum + " ");
            }

            Console.Write("How many records you want to display? : ");
            int num = Convert.ToInt32(Console.ReadLine());

            list.Sort();
            list.Reverse();

            Console.Write("The top {0} records from the list are: \n", num);
            foreach (int topn in list.Take(num))
            {
                Console.WriteLine(topn);
            }
            Console.ReadLine();
        }
    }
}
