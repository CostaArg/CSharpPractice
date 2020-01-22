using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace discoverMeRemove
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = new List<string> { "o", "elato", "o", "elato", "m' areseis", "pos", "m' areseis",  "o", "elato", "o", "elato", "m' areseis", "pos", "m' areseis"};
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

                text2.RemoveAll(elem => elem == text[i]);

                if (times >= 2)
                {
                    Console.WriteLine($"Word \"{text[i]}\" found {times} times");
                }

                times = 0;
            }
        }
    }
}