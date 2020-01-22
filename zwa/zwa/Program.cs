using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zwa
{
    class Animal 
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Place { get; set; }

        public void print()
        {
            Console.WriteLine("Name is: " + name);
        }
    }

    class Tiger : Animal
    {
        protected int numOfCubs;

        public void setNumOfCubs(int numOfCubs)
        {
            this.numOfCubs = numOfCubs;
        }

        public int getNumOfCubs()
        {
            return numOfCubs;
        }
    }

    class Monkey : Animal { }

    class Snake : Animal
    {
        protected int numOfEggs;

        public int NumOfEggs
        {
            get { return numOfEggs; }
            set { numOfEggs = value; }
        }

    }

    class WaterSnake : Snake
    {
        public void print()
        {
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Place is: " + Place);
            Console.WriteLine("Number of eggs: " + numOfEggs);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WaterSnake w1 = new WaterSnake();
            w1.Name = "Thanassis";
            w1.Place = "Ellada";
            w1.NumOfEggs = 7;
            w1.print();
        }
    }
}
