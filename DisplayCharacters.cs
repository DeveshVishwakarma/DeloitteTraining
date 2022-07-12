using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq_Task2
{
    internal class DisplayCharacters
    {
        public static void getCharacterFrequency() {
            string tempStr = "apple";


            var n = from x in tempStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    group x by x into y
                    select y;

            Console.WriteLine("\nThe frequency of the characters are : \n");
            foreach (var arrno in n)
            {
                Console.WriteLine("Character " + arrno.Key + " appears " + arrno.Count() + " times");
            }

            Console.ReadLine();
        }

    }
}
