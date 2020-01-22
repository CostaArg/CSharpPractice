using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classExcercise5dek
{
    class Program
    {
        static void Main(string[] args)
        {
            double ht;
            double wg;
            double BMI;
            string apotelesma;

            Console.WriteLine("Enter your height: ");
            ht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your weight: ");
            wg = Convert.ToDouble(Console.ReadLine());

            BMI = wg / (ht * ht);

            if (BMI <= 18.5)
                apotelesma = "Underweight";
            else if (BMI > 18.5 && BMI <= 24.9)
                apotelesma = "Normal weight";
            else if (BMI >= 25 && BMI <= 29.9)
                apotelesma = "Overweight ";
            else if (BMI > 30)
                apotelesma = "Obesity";
            else
                apotelesma = "Invalid";

            Console.WriteLine("You classify as: " + apotelesma);

        }
    }
}
