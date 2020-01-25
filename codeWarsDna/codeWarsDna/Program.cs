using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsDna
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class DnaStrand
    {
        public static string MakeComplement(string dna)
        {
            List<char> charList = new List<char>();

            charList.AddRange(dna);

            string opposite = null;

            for (int i = 0; i < charList.Count; i++)
            {
                if (charList[i] == 'T')
                    charList[i] = 'A';

                else if (charList[i] == 'A')
                    charList[i] = 'T';

                else if (charList[i] == 'C')
                    charList[i] = 'G';

                else if (charList[i] == 'G')
                    charList[i] = 'C';
            }

            foreach (var item in charList)
            {
                opposite += item;
            }

            return opposite;
        }
    }
}
