using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsBinaryConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] binaryArray = new int[8];
            binaryArray[0] = 128;
            binaryArray[1] = 64;
            binaryArray[2] = 32;
            binaryArray[3] = 16;
            binaryArray[4] = 8;
            binaryArray[5] = 4;
            binaryArray[6] = 2;
            binaryArray[7] = 1;

            List<char> givenBinaryList = new List<char>();

            Console.WriteLine("Give me number in binary: ");
            string givenBinary = Console.ReadLine();

            givenBinaryList.AddRange(givenBinary);

            int i = 0;
            int normalNumber = 0;

            while (i < 8)
            {
                if (givenBinaryList[i] == '1')
                {
                    normalNumber = normalNumber + binaryArray[i];
                }
                i++;
            }

            Console.WriteLine("Normal number is: " + normalNumber);

        }
    }
}
