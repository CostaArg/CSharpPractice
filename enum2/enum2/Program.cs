using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum2
{
    class Program
    {
        enum situation {baby, kid};
        static void Main(string[] args)
        {
            Console.WriteLine("Xrhsth dwse ena noumero:" );
            int noumero = Convert.ToInt32(Console.ReadLine());

            if (noumero <= 3)
                Console.WriteLine("To paidi sou einai " + situation.baby);
            else
                Console.WriteLine("To paidi sou einai " + situation.kid);

        }
    }
}
