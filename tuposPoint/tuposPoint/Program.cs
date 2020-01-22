using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuposPoint
{
    class Program
    {

        public struct aksonas
        {
            public int touxi;
            public int touyi;
        }
        static void Main(string[] args)
        {
            aksonas prwtos;
            prwtos.touxi = 5;
            prwtos.touyi = 4;

            aksonas deuteros;
            deuteros.touxi = -1;
            deuteros.touyi = 2;

            aksonas tritos;
            tritos.touxi = 3;
            tritos.touyi = -3;

            Console.WriteLine("A axis number is: " + "(" + prwtos.touxi + ", " + prwtos.touyi + ")");
            Console.WriteLine("B axis number is: " + "(" + deuteros.touxi + ", " + deuteros.touyi + ")");
            Console.WriteLine("C axis number is: " + "(" + tritos.touxi + ", " + tritos.touyi + ")");
        }
    }
}
