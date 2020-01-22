using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayParadeigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            arr = new int[5];
            Console.WriteLine(arr[2]);
            arr[2] = 5;
            Console.WriteLine(arr[2]);

            int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr3 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr4 = { 1, 2, 3, 4, 5 };

            dynamic patata = "wawa";
            patata = 1;
            Console.WriteLine(patata);

        }
    }
}
