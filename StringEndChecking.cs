using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq_Task2
{
    internal class StringEndChecking
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void checkStringEnd()
        {
            string temp2;
            char ch;
            var people = new List<StringEndChecking>();

            people.Add(new StringEndChecking { FirstName = "Bill", LastName = "Smith", Age = 41 });
            people.Add(new StringEndChecking { FirstName = "Sarah", LastName = "Jones", Age = 22 });
            people.Add(new StringEndChecking { FirstName = "Stacy", LastName = "Baker", Age = 21 });
            people.Add(new StringEndChecking { FirstName = "Vivianne", LastName = "Dexter", Age = 19 });
            people.Add(new StringEndChecking { FirstName = "Bob", LastName = "Smith", Age = 49 });
            people.Add(new StringEndChecking { FirstName = "Brett", LastName = "Baker", Age = 51 });
            people.Add(new StringEndChecking { FirstName = "Mark", LastName = "Parker", Age = 19 });
            people.Add(new StringEndChecking { FirstName = "Alice", LastName = "Thompson", Age = 18 });
            people.Add(new StringEndChecking { FirstName = "Evelyn", LastName = "Thompson", Age = 58 });
            people.Add(new StringEndChecking { FirstName = "Mort", LastName = "Martin", Age = 58 });
            people.Add(new StringEndChecking { FirstName = "Eugene", LastName = "DeLauter", Age = 84 });
            people.Add(new StringEndChecking { FirstName = "Gail", LastName = "Dawson", Age = 19 });


            Console.Write("\nLINQ : Find the string which starts and ends with a specific character : ");
            Console.Write("\n-----------------------------------------------------------------------\n");
            Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");

            Console.Write("\nInput starting character for the string : ");
            ch = (char)Console.Read();
            temp2 = ch.ToString();


            var _result = from x in people
                          where x.LastName.StartsWith(temp2)
                          select x;

            Console.Write("\n\n");
            int count = 0;

            foreach (var name in _result)
            {
                Console.Write("The Last Name ending with {0} is : {1} \n", temp2, name);
                count++;
            }

            Console.Write("The number of names ending with {0} is: {1}\n", temp2, count);

            Console.ReadLine();


        }
    }
}
