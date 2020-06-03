using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flipName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name and last name: ");
            string name = Console.ReadLine();
            Console.WriteLine(NameShuffler(name));
        }

        public static string NameShuffler(string str)
        {
            string[] nameList = str.Split(' ');
            string firstName = nameList[0];
            string lastName = nameList[1];
            return lastName + " " + firstName;
        }
    }
}
