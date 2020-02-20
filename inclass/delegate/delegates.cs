using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timesUpLetsDoThis
{
    class Program
    {
        static void Main(string[] args)
        {
            //delegates = tupos dedomenwn
            //sunarthsh me idia upografh me ton delegate

            //Human h1 = new Human();

            //Onoma del = new Onoma(Output);


            //del();
            //del();
            //del();
            //del();
            //del();
            //del();

            //Mitsos del2 = new Mitsos(Calculate);

            ////Mitsos del2 = Calculate; kai auto ginete me allh grafh

            //del2(40, 50);

            //Mitsos del3 = new Mitsos(CalculateMult);
            //del3(5, 5);

            ////-----------------------

            //Mitsos del4 = Calculate;
            //del4(45, 4);

            //del4 = CalculateMult;
            //del4(30, 6); //twra 8a kalesei thn mult

            //Takis del = Calculate;

            //int a = del(5,4);

            //Console.WriteLine(a);

            //Giorgos del = Output;

            //del += Display;
            //del += Display;

            //del();

            //Console.WriteLine("----------");

            //del -= Display;

            //del();

            //Human h1 = new Human() { Age = 33 };

            //GetAge(h1);

            //Print del = Output; //callback delegate

            //Greeting(del);

            Human h1 = new Human() { Name = "Panagiotis", Age = 35, Salary = 50500 };
            Human h2 = new Human() { Name = "Giorgis", Age = 22, Salary = 40003 };
            Human h3 = new Human() { Name = "Kotsos", Age = 41, Salary = 20304 };

            //Promote del = Check;

            //Sugkrisi(h1, del); //promotarete autos o anthropos me auto to condition?

            //Promote del = (p) => p.Salary > 45000 || p.Salary < 10000; // se anonimes methodous to belaki legete lambda expression

            Sugkrisi(h1, (p) => p.Salary > 45000 || p.Salary < 10000);

        }

        public static bool Check(Human p)
        {
            if (p.Age > 22 && p.Salary > 30000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Sugkrisi(Human p, Promote promoteCondition)
        {
            bool condition = promoteCondition(p);

            if (condition)
            {
                Console.WriteLine("promote this human");
            }
            else
            {
                Console.WriteLine("dont promote this human");
            }
        }

        public static void GetAge(Human hm)
        {
            Console.WriteLine(hm.Age);
        }

        public static void Output() //mporei na deiksei edw giati einai idiou tupou (void dld) + den exei parametrous
        {
            Console.WriteLine("Kalimera");
        }

        public static void Greeting(Print pr)
        {
            pr();
        }

        //public static void Display()
        //{
        //    Console.WriteLine("Kalispera");
        //}

        //public static int Calculate(int a, int b)
        //{
        //    return a + b;
        //}

        //public static int CalculateMult(int a, int b)
        //{
        //    return a * b;
        //}

    }





    class Human
    {
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Name { get; set; }
    }

    delegate void Onoma(); //upografh = void Onoma()

    //delegate void Mitsos(int a, int b);

    delegate int Takis(int a, int b);

    delegate void Giorgos();

    delegate void Print();

    delegate bool Promote(Human h);

    //delegate void Mydelegate();

    //delegate int Mydelegate2();

    //delegate string Mydelegate3();

    //delegate Human Mydelegate4();

    //delegate int Mydelegate5(int a, int b);

    //delegate void Mydelegate6(string str, string name, int a);

}
