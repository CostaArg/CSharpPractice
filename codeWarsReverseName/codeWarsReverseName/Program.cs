using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsReverseName
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

public class Kata
    {
        public static string NameShuffler(string str)
        {
            string[] nameList = str.Split(' ');
            string firstName = nameList[0];
            string lastName = nameList[1];
            return lastName + " " + firstName;
        }
    }
}
