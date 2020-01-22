using System;
using System.Collections.Generic;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] binaryArray = new int[4];
            //int[] binaryArray = new int[4] { 1, 1, 1, 1 };
            //int[] binaryArray = { 1, 1, 1, 1, 1, 1, 1, 1}
            //int[] binaryArray = new int[8];
            //List binaryArray = new List { 1, 1, 1, 1, 1, 1, 1, 1 };
            List binaryArray = new List();
            long result = 0;
            int i;
            //int a = 7, b = 3;
            //float c;
            //c = (float) a / b; // type casting

            /*
            binaryArray[0] = 0;
            binaryArray[1] = 1;
            binaryArray[2] = 0;
            binaryArray[3] = 1;

            for (i = 10; i > 0; i--) { // 10
            Console.WriteLine($"{11-i}: John!");
            }

            Console.WriteLine("\n");
            for (i = 0; i < binaryArray.Length; i++) {
            Console.Write("\tPlease give a bit value (0, 1): ");
            binaryArray[i] = Convert.ToInt16( Console.ReadLine() );
            Console.Write($"\tRemaining {binaryArray.Length-1-i} inputs..\n");
            }

            */

            Console.WriteLine("\n");
            for (i = 0; i < 8; i++)
            {
                Console.Write("\tPlease give a bit value (0, 1): ");
                binaryArray.Add(Convert.ToInt16(Console.ReadLine()));
                Console.Write($"\tRemaining {8 - 1 - i} inputs..\n");
            }


            Console.Write("\n\tYour digits are: ");
            foreach (int elem in binaryArray)
            {
                Console.Write(elem);
            }
            Console.WriteLine("\n");

            /*
            * for (i = 0; i < binaryArray.Length; i++){
            result = result + binaryArray[(binaryArray.Length - 1) - i] * (long)Math.Pow(2, i);
            }
            */

            for (i = 0; i < binaryArray.Count; i++)
            {
                result = result + binaryArray[(binaryArray.Count - 1) - i] * (long)Math.Pow(2, i);
            }

            /**
result = binaryArray[3] * (int)Math.Pow(2, 0);
result = result + binaryArray[2] * (int)Math.Pow(2, 1);
result = result + binaryArray[1] * (int)Math.Pow(2, 2);
result = result + binaryArray[0] * (int) Math.Pow(2, 3);
*/
            Console.WriteLine($"\tYour digit in decimal is: {result}");



            Console.ReadKey();
        }
    }
}