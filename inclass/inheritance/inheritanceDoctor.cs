using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    class Program
    {
        static void Main(string[] args)
        {
            Doctor d1 = new Doctor();
            Console.WriteLine(d1.age);
            d1.Output();
    }
    }

    //ta statika merh den klhronomounte
    class Human
    {
        public int age = 30;
        public int Salary { get; set; }

        public Human(int age)
        {
            this.age = age;
        }

        public void Output() //oti exw mesa stis agkules legete body methodou
        {
            Console.WriteLine("Eimai h class human");
        }
    }

    class Doctor : Human
    {
        //shadowing method h alliws hiding method

        public new int age { get; set; }
        public new int Salary { get; set; }

        public Doctor(int age, int Salary)
        {
            this.age = age;
            this.Salary = Salary;
        }

        public new void Output()
        {
            Console.WriteLine("Eimai h klash doctor");
        }
    }
}
