using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();

            a1.age = 33;
            a1.year = 2020;
            a1.Method1();

            A.salary = 5000;
            A.day = 7; //stigmiotipo dld a1 a2 a3
            A.Method2();
        }
    }

    class A
    {
        public int age; //non static field

        public static int salary; //static field

        public int year { get; set; }

        public static int day { get; set; }

        public void Method1()
        {
            Console.WriteLine("Eimai non static");
        }

        public static void Method2()
        {
            Console.WriteLine("Eimai static");
        }

        public A() //non static constructor
        {

        }

        static A() //static constructor
        {

        }
    }
}
