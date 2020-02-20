using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract2
{
    class Program
    {
        static void Main(string[] args)
        {
            C c1 = new C();
            c1.Method1();
            c1.Method2();
        }
    }

    abstract class A
    {
        public int age;
        public int Salary { get; set; }

        public abstract int Salary2 { get; set; } // get kai set den exoun ulopoih8ei

        public void Method1()
        {
            Console.WriteLine("Eimai h methodos 1");
        }

        public abstract void Method2();
    }

    abstract class B : A
    {
        public override int Salary2 { get; set; }
    }

    class C : B //concrete class = kanonikh class
    {
        public override void Method2()
        {
            Console.WriteLine("Eimai h methodos 2 ths class C");
        }
    }

}
