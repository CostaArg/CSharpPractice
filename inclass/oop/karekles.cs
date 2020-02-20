using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karekles
{
    class Program
    {
        static void Main(string[] args)
        {
            Chair c1 = new Chair(5.1, 2.4, 3.1, 10);
            Chair c2 = new Chair(2.4, 1.2, 4.4, 13);
            Chair c3 = new Chair(43, 3.2, 43, 100);
            Chair c4 = new Chair(3, 4, 2.3, 12);
            Chair c5 = new Chair(12.3, 12.1, 2.2, 34);

            List<Chair> Lista = new List<Chair>() {c1, c2, c3, c4, c5 };

            //Lista.Add(c1);
            //Lista.Add(c2);
            //Lista.Add(c3);
            //Lista.Add(c4);
            //Lista.Add(c5);

            foreach (var item in Lista)
            {
                Console.WriteLine(item.Height);
            }
        }
    }

    class Chair
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Weight { get; set; }

        public Chair() { }

        public Chair(double height, double width, double depth, double weight)
        {
            this.Height = height;
            this.Width = width;
            this.Depth = depth;
            this.Weight = weight;
        }



    }
}
