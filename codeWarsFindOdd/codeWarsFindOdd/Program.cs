using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsFindOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 5, 4, 4, 5};
            int ok = Kata.find_it(numbers);
            Console.WriteLine(ok);
        }
    }

    class Kata
    {
        public static int find_it(int[] seq)
        {
            List<string> text = new List<string>();
            List<string> text2 = new List<string>();
            List<int> timesList = new List<int>();

            foreach (var item in seq)
            {
                text.Add(Convert.ToString(item));
            }

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

                timesList.Add(times);

                text2.RemoveAll(elem => elem == text[i]);

                times = 0;
            }

            int position = 0;

            for (int i = 0; i < timesList.Count; i++)
            {
                if (timesList[i] % 2 != 0)
                {
                    position = i;
                    break;
                }
            }

            return Convert.ToInt32(text[position]);

        }

    }
}