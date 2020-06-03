using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palidromiki
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> xaraktiresList = new List<char>();

            Console.WriteLine("Enter a word: ");
            string leksi = Console.ReadLine();

            xaraktiresList.AddRange(leksi);

            for (int i = 0; i < xaraktiresList.Count; i++)
            {
                if ( (xaraktiresList[i] < 'A' || xaraktiresList[i] > 'Z') && (xaraktiresList[i] < 'a' || xaraktiresList[i] > 'z') )
                {
                    xaraktiresList[i] = ' ';
                }
            }

            List<char> xaraktiresList2 = new List<char>();
            xaraktiresList2.AddRange(leksi);
            xaraktiresList2.Reverse();

            xaraktiresList.RemoveAll(elem => elem == ' ');
            xaraktiresList2.RemoveAll(elem => elem == ' ');

            int fores = 0;
            string grammaprwths, grammadeuterhs;

            for (int i = 0; i < xaraktiresList.Count; i++)
            {
                grammaprwths = Convert.ToString(xaraktiresList[i]);
                grammadeuterhs = Convert.ToString(xaraktiresList2[i]);

                if (grammaprwths.ToUpper() == grammadeuterhs.ToUpper())
                { 
                    fores++;
                }
            }
            if (fores == xaraktiresList.Count)
            {
                Console.WriteLine("H leksi " + leksi + " einai palindromiki");
            }
            else
            {
                Console.WriteLine("H leksi " + leksi + " den einai palindromiki");
            }

            xaraktiresList2.Sort();

            string result = "";

            foreach (char xaraktiras in xaraktiresList2)
            {
                result = result + xaraktiras;
            }
            Console.WriteLine(result);
        }
    }
}
