using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectFrouta
{

    class Fruit
    {
        public double Price { get; set; }
        protected string shop;

        public void setShop (string s) { shop = s; }

        public string getShop () { return shop; }
    }

    class Banana : Fruit
    {
        public bool Ripe { get; set; }
        public string Origin { get; set; }

        public void print()
        {
            Console.WriteLine("Is the banana ripe? " + Ripe);
            Console.WriteLine("Where is the banana from? " + Origin);
        }

    }

    class Apple : Fruit
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public void print()
        {
            Console.WriteLine("What's the apple's color? " + Color);
            Console.WriteLine("What's the size of the banana? " + Size);
            Console.WriteLine("Shop name is: " + shop);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Banana b1 = new Banana();
            Apple a1 = new Apple();

            a1.Color = "green";
            a1.Size = 2;

            b1.Origin = "brazil";
            b1.Ripe = true;

            a1.setShop ("O Mpampis");

            a1.print();
            b1.print();

        }
    }
}
