using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsGetMiddleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string something = Kata.GetMiddle("middle");
            Console.WriteLine(something);
        }
    }

    public class Kata
    {
        public static string GetMiddle(string s)
        {
            List<char> charList = new List<char>();

            charList.AddRange(s);

            double length = charList.Count;
            string middle;

            if (length % 2 == 0)
            { 
                length = Math.Truncate(length / 2);
                int lengthI = Convert.ToInt32(length);
                middle = charList[lengthI - 1].ToString() + charList[lengthI].ToString();
            }
            else
            {
                length = Math.Truncate(length / 2);
                int lengthI = Convert.ToInt32(length);
                middle = charList[lengthI].ToString();
            }

            return middle;
        }
    }
}
