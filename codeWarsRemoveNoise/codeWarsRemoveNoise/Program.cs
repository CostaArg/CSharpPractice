using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsRemoveNoise
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.RemoveNoise("do$%k%$im@@i");
        }
    }

    public class Kata
    {
        public static string RemoveNoise(string equation)
        {
            List<char> charList = new List<char>();

            charList.AddRange(equation);

            List<char> newCharList = new List<char>();

            for (int i = 0; i < charList.Count; i++)
            {
                if (charList[i] != '@' && charList[i] != '$' && charList[i] != '%' && charList[i] != '#' && charList[i] != '·' && charList[i] != 'ª' && charList[i] != '/' && charList[i] != '&' && charList[i] != '|' && charList[i] != 'º' && charList[i] != 'ª' && charList[i] != '\\')
                {
                    newCharList.Add(charList[i]);                
                }
            }

            equation = string.Empty;

            foreach (var item in newCharList)
            {
                equation += item;
            }

            return equation;
        }
    }
}
