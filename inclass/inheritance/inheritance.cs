using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            

            B b = new B();

            A c = new B();

            c.name = "Hector";

            B d;

            d = (B)c;

            d.age = 2018;

            A giorgos = d; //implicit casting

            B mitsos = (B)giorgos; //explicit casting

            Console.WriteLine(mitsos.age);
        }
    }

    class A
    {
        public string name;
    }

    class B : A
    {
        public int age;
    }

    class Casting
    {
        public void Castaro()
        {
            //implicit casting

            int a = 5;

            double b;

            b = a; // b = (double)a; to double ennoeitai

            //explicit casting

            int c;

            double d = 5.5;

            c = (int)d;
        }
    }

}
