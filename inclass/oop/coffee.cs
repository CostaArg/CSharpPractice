using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enthilakosi
{


    class Coffee
    {
        private double cupSize;
        private bool beanDarkRoast;
        private string origin;

        public Coffee() { }

        public Coffee(double cupSize, bool beanDarkRoast, string origin)
        {
            this.cupSize = cupSize;
            this.beanDarkRoast = beanDarkRoast;
            this.origin = origin;
        }

        public double getCupSize()
        {
            return cupSize;
        }

        public bool getBeanDarkRoast()
        {
            return beanDarkRoast;
        }

        public string getOrigin()
        {
            return origin;
        }

        public void setCupSize(double cupSize)
        {
            Console.WriteLine("Enter your cup's size in cm: ");
            this.cupSize = Convert.ToDouble(Console.ReadLine());
        }

        public void setBeanDarkRoast(bool beanDarkRoast)
        {
            Console.WriteLine("Enter true or false if your bean is dark roast: ");
            this.beanDarkRoast = Convert.ToBoolean(Console.ReadLine());
        }

        public void setOrigin(string origin)
        {
            Console.WriteLine("Enter your coffee's origin: ");
            this.origin = Console.ReadLine();
        }

        public void print()
        {
            Console.WriteLine("Your cup size is: " + getCupSize() + " and your dark roast is: " + getBeanDarkRoast() + " and your origin is: " + getOrigin());
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Coffee c1 = new Coffee(50.1, true, "Nicaragua");

            c1.print();

            Coffee c2 = new Coffee();
            c2.setCupSize(c2.getCupSize());
            c2.setBeanDarkRoast(c2.getBeanDarkRoast());
            c2.setOrigin(c2.getOrigin());

            c2.print();

            Coffee[] Shelf = new Coffee[6];

            Coffee c3 = new Coffee();

            Shelf[0] = c1;
            Shelf[1] = c2;

            Shelf[2] = c3;

            //Shelf[2].setCupSize(Shelf[1].getCupSize()); me amesh ana8esh mono

            c3.print();

            Shelf[4] = new Coffee();

/*            foreach (Coffee c in Shelf)
            {
                c.print();
            }*/
        }
    }

}
