using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace embadonLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruit = new List<string>() { "apple", "pear", "grapes", "pineapple"};

            Random tuxaios = new Random();

            int fruitIndex = tuxaios.Next(fruit.Count);

            Console.WriteLine("Random fruit: " + fruit[fruitIndex]);
        }
    }
}
