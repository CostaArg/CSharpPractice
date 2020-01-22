using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace megaluterhLeksh
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lekseisList = new List<string>();
            List<bool> duplicateList = new List<bool>();

            int lekseisCounter = 0;
            int sameCounter = 0;
            string leksh;
            int i = 0;

            do
            {
                Console.WriteLine("Give me the {0} word: ", lekseisCounter + 1);
                leksh = Console.ReadLine();
                lekseisList.Add(leksh);
                lekseisCounter++;
            } while (leksh != "END");

            //find the same words
            foreach (string w in lekseisList)
                foreach (string d in lekseisList)
            {
                if (w == d)
                    {
                        sameCounter = sameCounter + 1;
                        duplicateList[i] = true;
                    }
                i++;
            }

            Console.WriteLine("Eixes tosa idia: " + sameCounter);

            //biggest word
            
            //2nd biggest word

        }
    }
}
