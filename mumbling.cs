using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mumbling
{
    class Program
    {
        static void Main(string[] args)
        {
            //method that repeats given letters based on string position - first is always capitalized
            Console.WriteLine("Give me a string: ");
            string s = Console.ReadLine();
            string something = Accumul.Accum(s);
            Console.WriteLine(something);
        }
    }

public class Accumul
    {
        public static String Accum(string s)
        {
            List<char> charList = new List<char>();
            charList.AddRange(s);
            List<string> stringList = new List<string>();
            string word = null;
            int counter = 1;

            foreach (var item in charList)
            {
                for (int i = 0; i < counter; i++)
                {
                    stringList.Add(Convert.ToString(item).ToUpper());
                }
                counter++;
                stringList.Add("-");
            }

            for (int i = 1; i < stringList.Count; i++)
            {
                if (stringList[i].ToUpper() == stringList[i - 1].ToUpper())
                    stringList[i] = stringList[i].ToLower();
            }

            foreach (var item in stringList)
            {
                word = word + item;
            }

            word = word.Remove(word.Length - 1);

            return word;
        }
    }
}
