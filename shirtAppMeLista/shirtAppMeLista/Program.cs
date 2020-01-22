using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shirtAppMeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colorsList = new List<string>() { "White", "Pink", "Red", "Green", "Blue", "Black"};

            List<string> sizesList = new List<string>() {"Small", "Medium", "Large", "X-Large"};

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            string stringage = Console.ReadLine();

            int age = Convert.ToInt32(stringage);

            while (age<0)
            {
                Console.WriteLine("Age should be positive, please re-enter your age: ");
                stringage = Console.ReadLine();

                age = Convert.ToInt32(stringage);
            }

            Console.WriteLine("Enter your weight: ");
            string stringweight = Console.ReadLine();

            double weight = Convert.ToDouble(stringweight);

            while (weight<0)
            {
                Console.WriteLine("Weight should be positive, please re-enter your weight: ");
                stringweight = Console.ReadLine();

                weight = Convert.ToDouble(stringweight);
            }

            string shirtcolor = "default";
            string shirtsize = "default";

            if (age > 0 && age <= 17)
            {
                shirtcolor = colorsList[0];
            }
            else if (age >= 18 && age <= 24)
            {
                shirtcolor = colorsList[1];
            }
            else if (age >= 25 && age <= 35)
            {
                shirtcolor = colorsList[2];
            }
            else if (age >= 36 && age <= 45)
            {
                shirtcolor = colorsList[3];
            }
            else if (age >= 46 && age <= 55)
            {
                shirtcolor = colorsList[4];
            }
            else if (age >= 56)
            {
                shirtcolor = colorsList[5];
            }

            if (weight >= 0 && weight < 50)
            {
                shirtsize = sizesList[0];
            }
            if (weight >= 50 && weight <= 64)
            {
                shirtsize = sizesList[1];
            }
            if (weight >= 65 && weight <= 79)
            {
                shirtsize = sizesList[2];
            }
            if (weight >= 80)
            {
                shirtsize = sizesList[3];
            }

            Console.WriteLine("Hey " + name + ", it is cool to be " + age + " years old! You should buy a " + shirtcolor + " " + shirtsize + " shirt.");
        }
    }
}