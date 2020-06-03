using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Kata.CreatePhoneNumber(numbers);
        }
    }

    public class Kata
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            List<string> stringList = new List<string>();

            int counter = 0;
            string phone = null;

            foreach (var item in numbers)
            {
                if (counter == 0)
                    stringList.Add("(");

                stringList.Add(item.ToString());

                if (counter == 2)
                    stringList.Add(") ");

                if (counter == 5)
                    stringList.Add("-");

                counter++;
            }

            foreach (var item in stringList)
            {
                phone += item;
            }

            Console.WriteLine(phone);

            return phone;
        }
    }
}
