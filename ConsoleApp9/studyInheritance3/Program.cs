using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyInheritance3
{
    class Program
    {
        static void Main(string[] args)
        {
            int kati = Method2();

            Console.WriteLine(kati);
        }

        public static int Method()
        {  //block methodou h alliws body
            return 5;
        }

        public static int Method2() => 5; //body expression legete to belaki kai olo legetai func

        public static void Method3()
        {
            Console.WriteLine("Hello");
        }

        public static void Method4() => Console.WriteLine("Hello"); //action

        public static bool Method5() => true; //predicate
    }
}
