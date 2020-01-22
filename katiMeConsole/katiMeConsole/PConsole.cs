using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSystem
{
    static class PConsole
    {
        public static void PWriteLine(string str)
        {
            Console.WriteLine(str);
        }
        public static void PWriteLine(int num)
        {
            Console.WriteLine(num);
        }

        public static string PReadLine()
        {
            return Console.ReadLine();
        }

        public static int PReadLineInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
