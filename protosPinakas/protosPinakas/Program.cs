using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protosPinakas
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] binaryArray = new int[4];

            /*binaryArray[0] = 1;
            binaryArray[1] = 1;
            binaryArray[2] = 1;
            binaryArray[3] = 1;*/

            //int[] binaryArray = new int[4] { 1, 1, 1, 1 };

            int[] binaryArray = { 1, 1, 1, 1 };

            int result, i;

            for (i=0; i < 10; i++)
            {
                Console.WriteLine("John");
            }

            result = binaryArray[3] * 1;
            result = result + binaryArray[2] * 2;
            result = result + binaryArray[1] * 2 * 2;
            result = result + binaryArray[0] * 2 * 2 * 2;

            Console.WriteLine(result);

        }
    }
}
