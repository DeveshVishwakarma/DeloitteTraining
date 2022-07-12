using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq_Task2
{
    internal class StringChecking
    {
        public void checkString() {
            string temp1, temp2;
            char ch;
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            Console.Write("\nLINQ : Find the string which starts and ends with a specific character : ");
            Console.Write("\n-----------------------------------------------------------------------\n");
            Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");

            Console.Write("\nInput starting character for the string : ");
            ch = (char)Console.Read();
            temp1 = ch.ToString();
            Console.Write("\nInput ending character for the string : ");
            ch = (char)Console.Read();
            temp2 = ch.ToString();


            var _result = from x in cities
                          where x.StartsWith(temp1)
                          where x.EndsWith(temp2)
                          select x;
            Console.Write("\n\n");
            foreach (var city in _result)
            {
                Console.Write("The city starting with {0} and ending with {1} is : {2} \n", temp1, temp2, city);
            }

            Console.ReadLine();
        }
    }
}
