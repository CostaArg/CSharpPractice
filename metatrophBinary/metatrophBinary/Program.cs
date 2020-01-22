using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metatrophBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] binaryArray;
            binaryArray = new int[8];
            binaryArray[0] = 128;
            binaryArray[1] = 64;
            binaryArray[2] = 32;
            binaryArray[3] = 16;
            binaryArray[4] = 8;
            binaryArray[5] = 4;
            binaryArray[6] = 2;
            binaryArray[7] = 1;

            int psifia = 0;

            int[] arithmoiArray;
            arithmoiArray = new int[8];


            while (psifia < 8)
            {
                Console.WriteLine("Dwse 0 h 1: ");
                arithmoiArray[psifia] = Int32.Parse(Console.ReadLine());

                while (arithmoiArray[psifia] != 0 && arithmoiArray[psifia] != 1)
                {
                    Console.WriteLine("Den edwses 0 h 1 parakalw ksanadwse ton arithmo: ");
                    arithmoiArray[psifia] = Int32.Parse(Console.ReadLine());
                }

                psifia++;
            }

            Console.WriteLine("You have that many digits: " + psifia);

            int i = 0;
            int kanonikosArithmos = 0;

            while (i < 8)
            {
                if (arithmoiArray[i] == 1)
                {
                    kanonikosArithmos = kanonikosArithmos + binaryArray[i];
                }
                i++;
            }

            Console.WriteLine("O arithmos sou einai: " + kanonikosArithmos);

        }
    }
}
