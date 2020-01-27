using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAraxni
{
    class Spider
    {
        public double weight;
        public double length;
        public string type;

        //empty constructor + arxikopoihsh
        public Spider() 
        {
            weight = 0.1;
            length = 0.1;
            type = "Unknown";
        }

        public Spider(string type)
        {
            weight = 0.1;
            length = 0.1;
            this.type = type;
        }

        public Spider(double weight, double length, string type)
        {
            this.weight = weight;
            this.length = length;
            this.type = type;
        }

        public void print ()
        {
            Console.WriteLine("The spider's weight is " + weight + " and its length is " + length + " and its type " + type);
        }

        public double getWeight()
        {
            return weight;
        }

        static void Main(string[] args)
        {
            Spider sp1 = new Spider();
            Spider sp2 = new Spider(150, 7.3, "N. America");
            Spider sp3 = new Spider("S. America");

            sp3.weight = sp2.weight;
            sp3.length = sp2.length - 1;

            sp1.weight = (sp2.weight + sp3.weight) / 2;
            //sp1.length = max * 2;

            Console.WriteLine("Give me the type of the first spider: ");
            sp1.type = Console.ReadLine();

            double max = -1;

            List<Spider> spiderList = new List<Spider>();
            spiderList.Add(sp1);
            spiderList.Add(sp2);
            spiderList.Add(sp3);

            foreach (var item in spiderList)
            {
                if (item.weight > max)
                {
                    max = item.weight;
                }
            }

            Console.WriteLine("Size of the biggest spider is: " + max);

            sp1.print();
            sp2.print();
            sp3.print();

        }
    }

}
