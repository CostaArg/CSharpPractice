using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Something.Printing();
            Something2 greetings = new Something2();
            greetings.Printing();
        }
    }

    public static class Something
    {
        public static void Printing()
        {
            Console.WriteLine("Yo");
        }
    }

    public class Something2
    {
        public void Printing()
        {
            Console.WriteLine("Hey hey hey");
        }
    }
}
