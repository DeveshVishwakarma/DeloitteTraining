using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq_Task2
{
    internal class StringStartChecking
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void checkStringStart()
        {
            string temp2;
            char ch;

            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" }; 

            Console.Write("\nLINQ : Find the string which starts with a specific character : ");
            

            Console.Write("\nInput starting character for the string : ");
            ch = (char)Console.Read();
            temp2 = ch.ToString();


            var _result = from x in fruits
                          where x.StartsWith(temp2)
                          select x;

            Console.Write("\n\n");
            int count = 0;

            foreach (var name in _result)
            {
                Console.Write("The Names starting with {0} is : {1} \n", temp2, name);
                count++;
            }

            Console.Write("The number of names ending with {0} is: {1}\n", temp2, count);

            Console.ReadLine();

        }
    }
