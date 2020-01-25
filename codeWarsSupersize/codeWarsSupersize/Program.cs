using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsSupersize
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = Kata.SuperSize(51432);
            Console.WriteLine(num);
        }
    }
    public class Kata
    {
        public static long SuperSize(long num)
        {
            string sNum = Convert.ToString(num);

            List<char> charList = new List<char>();

            charList.AddRange(sNum);
            charList.Sort();
            charList.Reverse();

            sNum = null;

            foreach (var item in charList)
            {
                sNum += item;
            }

            num = Convert.ToInt64(sNum);

            return num;
        }
    }
}
