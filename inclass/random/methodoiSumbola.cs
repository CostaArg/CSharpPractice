using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoiSumbola
{
    class Program
    {

        static double getArea(double r)
        {
            double area;
            area = (Math.PI * Math.Pow(r, 2));
            return area;
        }

        static double getPerimeter(double r)
        {
            double perimeter;
            perimeter = (2* Math.PI * r);
            return perimeter;
        }

        static double getR()
        {
            string arxikoR;
            double r;

            Console.WriteLine("Please enter r: ");
            arxikoR = Console.ReadLine();

            r = Convert.ToDouble(arxikoR);

            return r;
        }

        static void Main(string[] args)
        {
            double r, embadon, perimetros;

            r = getR();
            embadon = getArea(r);
            perimetros = getPerimeter(r);

            Console.WriteLine("Your area is: " + Math.Round(embadon));
            Console.WriteLine("Your perimeter is: " + Math.Round(perimetros));

        }
    }
}
