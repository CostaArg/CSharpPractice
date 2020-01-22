using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectMethodologia
{
    class Program
    {
        static void anadromh()
        {
            Console.WriteLine("ok");
            anadromh();
        }
        static void Main(string[] args)
        {
            anadromh();
        }
    }
}
