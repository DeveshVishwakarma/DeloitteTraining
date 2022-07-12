using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq_Task2
{
    internal class PeopleOlderThan40Asc
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Age { get; set; }

        public void olderThan40()
        {
            var people = new List<PeopleOlderThan40Asc>();

            people.Add(new PeopleOlderThan40Asc { First_Name = "Bill", Last_Name = "Smith", Age = 41 });
            people.Add(new PeopleOlderThan40Asc { First_Name = "Sarah", Last_Name = "Jones", Age = 22 });
            people.Add(new PeopleOlderThan40Asc { First_Name = "Stacy", Last_Name = "Baker", Age = 21 });
            people.Add(new PeopleOlderThan40Asc { First_Name = "Vivianne", Last_Name = "Dexter", Age = 19 });
            people.Add(new PeopleOlderThan40Asc { First_Name = "Bob", Last_Name = "Smith", Age = 49 });
            people.Add(new PeopleOlderThan40Asc { First_Name = "Brett", Last_Name = "Baker", Age = 51 });
            people.Add(new PeopleOlderThan40Asc { First_Name = "Mark", Last_Name = "Parker", Age = 19 });
            people.Add(new PeopleOlderThan40Asc { First_Name = "Alice", Last_Name = "Thompson", Age = 18 });
            people.Add(new PeopleOlderThan40Asc { First_Name = "Evelyn", Last_Name = "Thompson", Age = 58 });
            people.Add(new PeopleOlderThan40Asc { First_Name = "Mort", Last_Name = "Martin", Age = 58 });
            people.Add(new PeopleOlderThan40Asc { First_Name = "Eugene", Last_Name = "DeLauter", Age = 84 });
            people.Add(new PeopleOlderThan40Asc { First_Name = "Gail", Last_Name = "Dawson", Age = 19 });

            var result = from d in people
                         orderby d.First_Name ascending
                         where d.Age > 40
                         select d;

            Console.WriteLine("The names of people older than 40 in ascending order are: \n");

            foreach (var item in result)
            {
                Console.WriteLine(item.First_Name);
            }

            Console.ReadLine();

        }

        }
    }
