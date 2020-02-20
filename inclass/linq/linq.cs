using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathimaLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listString = new List<string> { "mitsos", "makis", "manolis", "kostas", "thanassis", "giorgos" };
            List<int> listInt = new List<int> { 1, 5, 6, 4, 3, 7, 1 };

            //int sum = listInt.Sum();
            //Console.WriteLine(sum);

            //var a = listInt.Count(x => x > 5); //posoi ari8moi einai megaluteroi tou 5
            //Console.WriteLine(a);

            //Predicate<int> mitsos = IsValid;
            //Console.WriteLine(mitsos(4));

            //Predicate<int> mitsos = delegate (int a)
            //{
            //    return a > 5 && a < 10;
            //};

            //Predicate<int> mitsos = a => a > 5 && a < 10; //einai anonymous method giauto legetai lamda expression

            //Console.WriteLine(Sum(listInt, a => a.age > 5 && a.age < 10));

            Func<int, int, int> mitsos = (x, y) => x * y;

            Predicate<int> takis = a => a > 10; //epistrefei mono bool

            Func<int, bool> makis = x => x > 5; //epistrefei oti tou dwsw (bool, string, whatever)

            //Console.WriteLine(listInt.Count(makis));

            Console.WriteLine(listInt.Count(x => x > 5));

            listInt.All(x => x > 5); //foreach in list is item > 5 ?

            listInt.Any(x => x == 9); // if x == 9 returns true

            var lista = listInt.Select(x => x > 5);

        } 

        //class Student
        //{
        //    int age;
        //}

        //public static void Sum(IEnumerable<int> ts, Predicate<int> conditioner)
        //{
        //    int sum = 0;
        //    foreach (var item in ts)
        //    {
        //        sum = sum + item;
        //    }

        //    return sum;
        //}
        
        //public static bool IsValid(int a)
        //{
        //    return a > 5;
        //}


        //public static void Sum(IEnumerable<int> ts)
        //{
        //    int sum = 0;
        //    foreach (var item in ts)
        //    {
        //        sum = sum + item;
        //    }

        //    return sum;
        //}

    }
}
