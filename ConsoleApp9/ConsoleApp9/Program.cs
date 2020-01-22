using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ipallilos f = new Doctor();

            //Doctor g = (Doctor)new Ipallilos();

            //List<Doctor> doctors = new List<Doctor>();

            List<Ipallilos> ipalliloi = new List<Ipallilos>();

            Ipallilos i1 = new Ipallilos();
            i1.Name = "Hector";
            i1.Salary = 10000;

            Ipallilos i2 = new Ipallilos() { Name = "Giannis" , Salary = 5000};
            Ipallilos i3 = new Ipallilos() { Name = "Eleni", Salary = 2475 };
            Ipallilos i4 = new Ipallilos() { Name = "Konstantinos", Salary = 3767 };
            Ipallilos i5 = new Ipallilos() { Name = "Zaxarias", Salary = 2828 };

            Ipallilos d1 = new Doctor() { Name = "Spiros", Salary = 3645 };
            Ipallilos d2 = new Doctor() { Name = "Xaralampos", Salary = 8254 };
            Ipallilos d3 = new Doctor() { Name = "Petros", Salary = 4857 };
            Ipallilos d4 = new Doctor() { Name = "Dimitris", Salary = 1638 };
            Ipallilos d5 = new Doctor() { Name = "Maria", Salary = 1999 };

            ipalliloi.Add(i1);
            ipalliloi.Add(i2);
            ipalliloi.Add(i3);
            ipalliloi.Add(i4);
            ipalliloi.Add(i5);

            ipalliloi.Add(d1);
            ipalliloi.Add(d2);
            ipalliloi.Add(d3);
            ipalliloi.Add(d4);
            ipalliloi.Add(d5);

            foreach (var ipallilo in ipalliloi)
            {
                if (ipallilo.Salary > 4000)
                {
                    ipallilo.Output();
                }
            }

            //foreach (var giatro in doctors)
            //{
            //    if(giatro.Salary > 4000)
            //    {
            //        giatro.Output();
            //    }
            //}
        }
    }

    class Ipallilos
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public virtual void Output()
        {
            Console.WriteLine("Eimai o " + Name + " kai eimai ths class ipallilos");
        }
    }

    class Doctor : Ipallilos
    {
        public override void Output()
        {
            Console.WriteLine("Eimai o " + Name + " kai eimai ths class doctor");
        }
    }
}

