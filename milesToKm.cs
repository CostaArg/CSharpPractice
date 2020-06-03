using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diairesh
{
    class Program
    {
        static void Main(string[] args)
        {

            string speedkm;
            double speedkmArithmos, speedmiles;

            Console.WriteLine("Enter speed in km: ");
            speedkm = Console.ReadLine();
            speedkmArithmos = Convert.ToDouble(speedkm);

            while (speedkmArithmos < 0) 
            {
                Console.WriteLine("Speed must be positive, please re-enter speed: ");
                speedkm = Console.ReadLine();
                speedkmArithmos = Convert.ToDouble(speedkm);
            }

            speedmiles = speedkmArithmos * 0.621371192;

            if (speedkmArithmos > 120)
            {
                Console.WriteLine("Your speed is: " + speedmiles + " miles and overspeed!");
            }
            else if (speedkmArithmos <= 120)
            {
                Console.WriteLine("Your speed is: " + speedmiles + " miles and not overspeed.");
            }
        }
    }
}
