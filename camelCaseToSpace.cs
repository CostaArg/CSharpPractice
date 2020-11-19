using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camelCaseCodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Kata.BreakCamelCase("helloThere");
            Console.WriteLine(result);
        }
    }

    public class Kata
    {
        public static string BreakCamelCase(string str)
        {
            List<char> charList = new List<char>();
            charList.AddRange(str);
            string word = "";

            foreach (var item in charList)
            {
                if (item.ToString().ToUpper() == item.ToString())
                {
                    word += " " + item.ToString().ToLower();
                }
                else
                {
                    word += item;
                }
            }
            return word;
        }
    }
}
