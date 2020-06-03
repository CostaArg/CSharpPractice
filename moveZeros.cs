using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moveZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements

            int[] arr = { 1, 0, 2, 0, 0, 0, 5, 7, 0, 4 };
            arr = Kata.MoveZeroes(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> numberList = new List<int>();
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                    numberList.Add(arr[i]);
                else
                    counter++;
            }

            for (int i = 0; i < counter; i++)
            {
                numberList.Add(0);
            }

            arr = numberList.ToArray();

            return arr;
        }
    }
}
