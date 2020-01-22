using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void Manager()
        {
            string onoma = InputName();
            string epitheto = InputLastName();
            int age = InputAge();

            if (age > 100)
            {
                OutputMessage();
            }
        }

        public static string InputName() //DRY DONT REPEAT YOURSELF
        {
            Console.WriteLine("Dwse onoma");
            string onoma = Console.ReadLine();

            return onoma;
        }

        public static string InputLastName()
        {
            Console.WriteLine("Dwse epitheto");
            string epitheto = Console.ReadLine();

            return epitheto;
        }

        public static int InputAge()
        {
            Console.WriteLine("Dwse hlikia");
            int age = Convert.ToInt32(Console.ReadLine());

            return age;
        }

        public static void OutputMessage()
        {
            Console.WriteLine("Eisai uperilikas");
        }

    }
}
