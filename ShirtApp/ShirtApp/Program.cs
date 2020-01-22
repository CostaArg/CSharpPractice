using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colorsarr;
            colorsarr = new string[6];
            colorsarr[0] = "White";
            colorsarr[1] = "Pink";
            colorsarr[2] = "Red";
            colorsarr[3] = "Green";
            colorsarr[4] = "Blue";
            colorsarr[5] = "Black";

            string[] sizearr;
            sizearr = new string[4];
            sizearr[0] = "Small";
            sizearr[1] = "Medium";
            sizearr[2] = "Large";
            sizearr[3] = "X-Large";

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            string stringage = Console.ReadLine();
            Console.WriteLine("Enter your weight: ");
            string stringweight = Console.ReadLine();

            int age = Convert.ToInt32(stringage);
            int weight = Convert.ToInt32(stringweight);

            string shirtcolor = "default";
            string shirtsize = "default";

            if (age > 0 && age <= 17)
            {
                shirtcolor = colorsarr[0];
            }
            else if (age >= 18 && age <= 24)
            {
                shirtcolor = colorsarr[1];
            }
            else if (age >= 25 && age <= 35)
            {
                shirtcolor = colorsarr[2];
            }
            else if (age >= 36 && age <= 45)
            {
                shirtcolor = colorsarr[3];
            }
            else if (age >= 46 && age <= 55)
            {
                shirtcolor = colorsarr[4];
            }
            else if (age >= 56)
            {
                shirtcolor = colorsarr[5];
            }

            if (weight >= 0 && weight < 50)
            {
                shirtsize = sizearr[0];
            }
            if (weight >= 50 && weight <= 64)
            {
                shirtsize = sizearr[1];
            }
            if (weight >= 65 && weight <= 79)
            {
                shirtsize = sizearr[2];
            }
            if (weight >= 80)
            {
                shirtsize = sizearr[3];
            }

            Console.WriteLine("Hey " + name + ", it is cool to be " + age + " years old! You should buy a " + shirtcolor + " " + shirtsize + " shirt");
        }
    }
}
