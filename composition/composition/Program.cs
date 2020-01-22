using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composition
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ipallilos> ipalliloi = new List<Ipallilos>();

            List<House> houses = new List<House>();

            List<Task> tasks = new List<Task>();

            Ipallilos i1 = new Ipallilos();
            i1.Id = 1;
            i1.Name = "Ektoras";
            i1.Age = 33;

            House h1 = new House();
            h1.Address = "Smirnis 12";
            h1.ZipCode = "CG 7575";

            House h2 = new House();
            h2.Address = "Omonias 32";
            h2.ZipCode = "FG 4675";

            House h3 = new House();
            h3.Address = "Thiseos 14";
            h3.ZipCode = "HB 7585";

            Task t1 = new Task();
            t1.Title = "Clear Desktop";
            t1.StartDate = 2020;
            t1.EndDate = 2021;
            t1.Diskolia = Difficulty.hard;
            t1.Condition = "H katatastash einai tragikh";

            Task t2 = new Task();
            t2.Title = "Clear Laptop";
            t2.StartDate = 2020;
            t2.EndDate = 2021;
            t2.Diskolia = Difficulty.easy;
            t2.Condition = "Ola kala";

            houses.Add(h1);
            houses.Add(h2);
            houses.Add(h3);

            tasks.Add(t1);
            tasks.Add(t2);

            i1.House = h1;
            i1.Task = t2;

            ipalliloi.Add(i1);


            Console.WriteLine("--- Now printing Employee List ---");

            foreach (var item in ipalliloi)
            {
                item.Output();
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("--- Now printing Tasks List ---");

            foreach (var item in tasks)
            {
                item.Output();
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("--- Now printing Houses List ---");

            foreach (var item in houses)
            {
                item.Output();
                Console.WriteLine("--------------------");
            }

        }
    }

    class Ipallilos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Task Task { get; set; }
        public House House { get; set; }

        public void Output()
        {
            Console.WriteLine("--- EMPLOYEE ---");
            Console.WriteLine("Id " + Id);
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Age " + Age);
            Task.Output();
            House.Output();
        }

    }

    public class House
    {
        public string Address { get; set; }
        public string ZipCode { get; set; }

        public void Output()
        {
            Console.WriteLine("--- HOME ---");
            Console.WriteLine("Address " + Address);
            Console.WriteLine("Zip Code " + ZipCode);
        }

    }


    class Task
    {
        public string Title { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public Difficulty Diskolia { get; set; }
        public string Condition { get; set; }

        public void Output()
        {
            Console.WriteLine("--- TASK ---");
            Console.WriteLine("Title " + Title);
            Console.WriteLine("Start Date " + StartDate);
            Console.WriteLine("End Date " + EndDate);
            Console.WriteLine("Difficulty " + Diskolia);
            Console.WriteLine("Condition " + Condition);
        }

    }

    public enum Difficulty
    {
        easy,
        medium,
        hard
    }



}

