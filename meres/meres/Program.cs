using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meres
{
    class Program
    {
        enum Days { Sun = 10, Mon, Tue, Wed, Thu, Fri, Sat }
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Sun);
            int x = (int)Days.Sun;
            Console.WriteLine(x);
            Console.WriteLine(DayOfWeek.Friday);
            Console.WriteLine((int)DayOfWeek.Friday);
        }
    }
}
