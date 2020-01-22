using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = new List<string> { "o", "elato", "o", "elato", "m'areseis", "pos", "m'areseis", "o", "elato", "o", "elato", "m'areseis", "pos", "m'areseis" };
            List<string> text2 = new List<string>();
            text2.AddRange(text);

            int times = 1;

            for (int i = 0; i < text.Count; i++)
            {
                for (int j = i + 1; j < text.Count; j++)
                {
                    if (text[i] == text[j])
                    {
                        text2[j] = " ";
                        times++;
                    }
                }
                if ((times >= 2) && (text2[i] != " "))
                {
                    Console.WriteLine($"Leksi \"{text2[i]}\" brethike {times} fores ");
                }

                times = 1;
            }
        }
    }
}
