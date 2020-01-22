using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Pawn p1 = new Pawn(); Den mporeis na to kaneis se abstract class
            Pawn p1 = new King(); //mporw
        }
    }

    abstract class Pawn
    {
        public string Color { get; set; }

        public void Output()
        {
            Console.WriteLine("Eimai h methodos output ths pawn");
        }

        public abstract void Display();
    }

    abstract class King : Pawn
    {
        public override void Display()
        {
            Console.WriteLine("Einai h display tou king");
        }
    }

    abstract class Queen : Pawn
    {
        public override void Display()
        {
            Console.WriteLine("Einai h display tou king");
        }
    }

    class Human
    {
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
