using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsCipher26encrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "thisisencryptedmessage";
            string encrypted = Kata.Cipher26(message);
            Console.WriteLine(encrypted);
        }
    }

    public class Kata
    {
        public static string Cipher26(string message)
        {
            List<char> alphabet = new List<char>();

            for (int i = 97; i < 123; i++)
            {
                alphabet.Add(Convert.ToChar(i));
            }

            List<char> rawLetters = new List<char>();
            rawLetters.AddRange(message);

            List<int> letterPositions = new List<int>();

            foreach (var item in rawLetters)
            {
                letterPositions.Add(alphabet.IndexOf(item));
            }

            for (int i = 1; i < letterPositions.Count; i++)
            {
                letterPositions[i] = letterPositions[i - 1] + letterPositions[i];
            }

            List<char> encryptedLetters = new List<char>();

            for (int i = 1; i < letterPositions.Count; i++)
            {
                letterPositions[i] = letterPositions[i] % 26;
            }

            foreach (var item in letterPositions)
            {
                Console.WriteLine("Will convert number: " + item);
                encryptedLetters.Add(alphabet[item]);
                Console.WriteLine("Result was: " + alphabet[item]);
            }

            string encryptedWord = null;

            foreach (var item in encryptedLetters)
            {
                encryptedWord += item;
            }

            Console.WriteLine(encryptedWord);

            return encryptedWord;
        }
    }
}
