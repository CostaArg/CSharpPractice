using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsLostWithoutMap
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Kata
    {
        public static int[] Maps(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = x[i] * 2;
            }
            return x;
        }
    }
}
