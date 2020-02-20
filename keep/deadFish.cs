using System;
using System.Collections.Generic;

namespace deadFish
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

            // i increments the value (initially 0)
            // d decrements the value
            // s squares the value
            // o outputs the value into the return array

            List<char> charList = new List<char>();

            charList.AddRange(data);

            string newData = null;
            double counter = 0;

            foreach (var item in charList)
            {
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
