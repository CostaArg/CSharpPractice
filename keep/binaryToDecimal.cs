using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.BinaryToString("101010101");
        }

        public static class Kata
        {
            public static string BinaryToString(string binary)
            {
                if (binary == null)
                    return "";

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

                string givenBinary = Convert.ToString(binary);
                givenBinaryList.AddRange(givenBinary);

                int i = 0;
                int normalNumber = 0;

                while (i < 8)
                {
                    if (givenBinaryList[i] == '1')
                    {
                        normalNumber += binaryArray[i];
                    }
                    i++;
                }

                Console.WriteLine("Normal number is: " + normalNumber);

                return binary.ToString();
            }

        }
    }
}