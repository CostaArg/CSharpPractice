using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectPingPong
{
    class Program
    {
        static void Main(string[] args)
        {

            string spacing = " ";

            for (int i = 0; i < 3;  i++)
            {
                Console.WriteLine("||");
            }

            for (int i = 0; i < 3; i++)
            {
                spacing = spacing + " ";
                Console.WriteLine(spacing);

                if (i == 2)
                Console.WriteLine(spacing + "O");

            }
        }
    }
}
