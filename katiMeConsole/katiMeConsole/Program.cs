using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSystem;

namespace katiMeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a name: ");
            string name = PConsole.PReadLine();
            PConsole.PWriteLine("The name is: " + name);
        }
    }
}
