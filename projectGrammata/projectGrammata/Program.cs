using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectGrammata
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 keno >= 20 length
            //sumfona + fwnhenta

            List<char> xaraktiresList = new List<char>();

            bool valid = false;

            do
            {
                Console.WriteLine("Enter a sentence: ");
                string sentence = Console.ReadLine();

                xaraktiresList.AddRange(sentence);

                for (int i = 0; i < xaraktiresList.Count; i++)
                {
                    if ((xaraktiresList[i] >= 'A' && xaraktiresList[i] <= 'Z') || (xaraktiresList[i] >= 'a' && xaraktiresList[i] <= 'z') || (xaraktiresList[i] = " "))
                    {
                        valid = true;
                    }
                }

            } while (valid == true);

            


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
    }
}
