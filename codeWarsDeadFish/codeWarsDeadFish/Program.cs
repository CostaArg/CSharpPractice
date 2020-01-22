using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsDeadFish
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter stuff: ");
            string stuff = "iiisdoso";

            Deadfish.Parse(stuff);
        }
    }

    public class Deadfish
    {
        public static int[] Parse(string data)
        {
            // Return the output array, and ignore all non-op characters

            List<char> charList = new List<char>();

            charList.AddRange(data);

            string newData = null;
            double counter = 0;

            foreach (var item in charList)
            {
                //if (item == 'i' || item == 'd' || item == 's' || item == 'o')
                //    newData += item;

                if (item == 'i')
                    counter++;

                if (item == 'd')
                    counter--;

                if (item == 's')
                    counter = Math.Pow(counter, 2);

                if (item == 'o')
                    newData += item;
            }

            List<char> newCharList = new List<char>();

            newCharList.AddRange(newData);

            List<int> newIntList = new List<int>();

            foreach (var item in newCharList)
            {
                newIntList.Add(Convert.ToInt32(item));
            }

            int[] intArray;

            intArray = newIntList.ToArray();

            return intArray;
        }
    }
}
