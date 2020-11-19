using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertToCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //If the first word is capitalized then the output will be "Pascal Case", else it will be "Camel Case"
            Console.WriteLine(Kata.ToCamelCase("hello_how_are_you_doing"));
        }
    }

    public class Kata
    {
        public static string ToCamelCase(string str)
        {
            bool isUpper = Char.IsUpper(str[0]);

            var filteredArray = str.Contains("-") ? str.Split('-') : str.Split('_');

            var result = String.Join("", filteredArray.Select(x => x[0].ToString().ToUpper() + x.Substring(1, x.Count() - 1).ToLower()));

            return isUpper ? result : result[0].ToString().ToLower() + result.Substring(1, result.Length - 1);
        }
    }
}
