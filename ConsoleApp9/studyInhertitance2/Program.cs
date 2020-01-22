using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyInhertitance2
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            A b = new C();

            a.Output();
            b.Output();

            A c = new B();
        }

       
    }

    class A
    {

        //public virtual int age { get; set; }
        //public override string ToString()
        //{
        //    return "A";
        //}

        public virtual void Output()
        {
            Console.WriteLine("Eimai ths a");
        }
    }

    class B : A
    {
        public override void Output()
        {
            Console.WriteLine("Eimai ths b");
        }
    }

    class C : B
    {
        public override void Output()
        {
            Console.WriteLine("Eimai ths c");
        }
    }
}
