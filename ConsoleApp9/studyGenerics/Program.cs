using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            if( Compare (5,6) )
            {
                Console.WriteLine("einai idia");
            }
            else
            {
                Console.WriteLine("den einai idia");
            }

            Compare("5", "6");
        }

        public static bool Compare(int a, int b)
        {
            return a == b;
        }

        public static bool Compare<T>(T a, T b) //idiou tupou
        {
            return a.Equals(b);
        }

        public static bool Compare2<T1, T2>(T1 a, T2 b) //diaforetikou tupou
        {
            return a.Equals(b);
        }
    }
}
