using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4dekAsk5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your dog's age: ");
            int dogAge = Convert.ToInt32(Console.ReadLine());

            while (dogAge <= 0)
            {
                Console.WriteLine("Age must be positive, please re-enter your dog's age: ");
                dogAge = Convert.ToInt32(Console.ReadLine());
            }

            if (dogAge <= 2)
            {
                Console.WriteLine("Your dog's age in human age is: " + dogAge);
            }
            else if (dogAge > 2 && dogAge <= 30)
            {
                dogAge = dogAge - 2;
                dogAge = dogAge * 5;
                dogAge = dogAge + 2;
                Console.WriteLine("Your dog's age in human age is: " + dogAge);
            }
            else
            {
                Console.WriteLine("Invalid dog age");
            }
        }
    }
}
