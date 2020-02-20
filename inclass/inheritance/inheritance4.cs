using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //A a1 = new A(2018);
            B b1 = new B();
        }
    }

    class A
    {

        public int age { get; set; }
        public A(int a)
        {
            age = a;
        }

        public A(int a, int b)
        {
            age = b;
        }
    }

    class B : A
    {
        public new int age { get; set; }

        public B() :base(2018, 2019) //bazw 2 times gia na ftiaxtei me ton 2 parameter constructor
        {
            Console.WriteLine(age);
        }
    }
}
