using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getMiddleChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string midLetter = GetMiddle("middle");
            Console.WriteLine(midLetter);
        }

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
