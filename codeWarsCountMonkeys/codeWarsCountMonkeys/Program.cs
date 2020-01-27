using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsCountMonkeys
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class MonkeyCounter
    {
        public static int[] MonkeyCount(int n)
        {
            List<int> numberList = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                numberList.Add(i);
            }

            return numberList.ToArray();
        }
    }
}
