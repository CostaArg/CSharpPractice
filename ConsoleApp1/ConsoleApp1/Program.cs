using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //primitives

            //float decimal int bool char = value types

            //string = REFERENCE type (alla gia anagkes eukolias sumperiferete san value type, sthn ousia einai enas character list)

            string str = "Afroksilanthi";

            Onoma(str);

            Console.WriteLine(str);
        }

        public static void Onoma(string a) //pass by reference
        {
            a = "Sofia";
            Console.WriteLine(a);
        }
    }
}
