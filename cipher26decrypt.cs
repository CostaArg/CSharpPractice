using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsCipher26decrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string decryptedMessage = Kata.Cipher26("taiaiaertkixquxjnfxxdh");
            Console.WriteLine(decryptedMessage);
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

            List<char> encryptedLetters = new List<char>();
            encryptedLetters.AddRange(message);

            List<int> letterPositions = new List<int>();

            foreach (var item in encryptedLetters)
            {
                letterPositions.Add(alphabet.IndexOf(item));
            }

            List<int> decryptedNumbers = new List<int>();

            decryptedNumbers.Add(letterPositions[0]);

            for (int i = 1; i < letterPositions.Count; i++)
            {
                int decryptedNumber = 0;
                int current = letterPositions[i];
                int previous = letterPositions[i - 1];

                for (int j = 0; j < 26; j++)
                {
                    if ((previous + decryptedNumber) % 26 == current)
                    {
                        decryptedNumbers.Add(decryptedNumber);
                        break;
                    }
                    else
                        decryptedNumber++;
                }
            }

            List<char> decryptedLetters = new List<char>();

            foreach (var item in decryptedNumbers)
            {
                decryptedLetters.Add(alphabet[item]);
            }

            string decryptedMessage = null;

            foreach (var item in decryptedLetters)
            {
                decryptedMessage += item;
            }

            return decryptedMessage;
        }
    }
}
