using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rot13CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Rot13("Grfg"));
        }
    }

    public class Kata
    {
        public static string Rot13(string message)
        {
            List<char> charList = new List<char>();
            charList.AddRange(message);

            List<int> numList = new List<int>();

            foreach (var item in charList)
            {
                int num = 0;

                if (char.IsLower(item))
                {
                    num = Convert.ToInt32(item) + 13;

                    if (num > 122)
                    {
                        numList.Add(num - 26);
                    }
                    else
                    {
                        numList.Add(num);
                    }
                }
                else if (char.IsUpper(item))
                {
                    num = Convert.ToInt32(item) + 13;

                    if (num > 90)
                    {
                        numList.Add(num - 26);
                    }
                    else
                    {
                        numList.Add(num);
                    }
                }
                else
                {
                    numList.Add(Convert.ToInt32(item));
                }
            }

            string ciphered = "";

            foreach (var item in numList)
            {
                ciphered += Convert.ToChar(item).ToString();
            }

            return ciphered;
        }
    }
}
