using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;

            Random tuxaios = new Random();

            int tuxaiosArithmos = tuxaios.Next(1, 101);

            do
            {

                do
                {
                    Console.WriteLine("Guess the random number: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                while (guess < 1 && guess > 100);


                    if (guess > tuxaiosArithmos)
                    {
                        Console.WriteLine("Your guess was bigger than the number");
                    }
                    else
                    {
                        Console.WriteLine("Your guess was smaller than the number");
                    }
                
            }
            while (guess != tuxaiosArithmos);

            Console.WriteLine("EUREKA!!! The number was: " + guess);


        }
    }
}
