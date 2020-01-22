using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace dikiaMasRemove
{
    class Program
    {

        static List<string> myRemoveAll(List<string> aList, string aString) 
            {
            List<string> newList = new List<string>();
            foreach (string s in aList)
            {
                if (s != aString)
                    newList.Add(s);
            }

            return newList;
            }

        static string getMaxWord(List<String> aList)
        {
            string s = aList[0];

            for (int i = 0; i < aList.Count; i++)
            {

            }
        }

        static char getChar(string word, int num)
        {
            return word[num];
        }

        static int prosthesi(int x, int y)
        {
            return x + y;
        }

        static int diairesi(int x, int y)
        {
            return x / y;
        }

        static int pollaplasiasmos(int x, int y)
        {
            return x * y;
        }

        static int afairesi(int x, int y)
        {
            return x - y;
        }
        static void Main(string[] args)
        {
            List<string> text = new List<string> { "o", "elato", "o", "elato", "m' areseis", "pos", "m' areseis", "o", "elato", "o", "elato", "m' areseis", "pos", "m' areseis" };
            List<string> text2 = new List<string>();

            text2.AddRange(text);

            int times = 0;
            for (int i = 0; i < text.Count; i++)
            {
                for (int j = 0; j < text2.Count; j++)
                {
                    if (text[i] == text2[j])
                    {
                        times++;
                    }
                }

                text2 = myRemoveAll(text2, text[i]);
                times = 0;

                if (times >= 2)
                {
                    Console.WriteLine($"Word \"{text[i]}\" found {times} times");
                }

            }

            float a = prosthesi(3, 2);
            float b = afairesi(9, 1);
            float c = diairesi(6, 3);
            float d = pollaplasiasmos(4, 2);
            float e = pollaplasiasmos(a, b);

            Console.WriteLine("Result is: " + pollaplasiasmos(prosthesi(8,2), diairesi(9, 1)));

            Console.WriteLine(getChar("Thanasis", 0));

            string myName = "Dionysis";

            Console.WriteLine("First letter is: {0} and last letter: {1}."),
            getChar(myName, 0), getChar(myName, myName.Length-1));

            for (int i = 0; i < myName.Length; i++)
            {
                Console.Write(getChar(myName, i) + "***");
            }
        }
    }
}