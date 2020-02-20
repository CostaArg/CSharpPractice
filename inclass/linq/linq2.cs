using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathimaLinq2
{
    class Program
    {
        static void Main(string[] args)
        {
            Experiment ex1 = new Experiment() { Id = 1, Title = "Lobotomi" };
            Experiment ex2 = new Experiment() { Id = 2, Title = "Akrotiriasmos" };
            Experiment ex3 = new Experiment() { Id = 3, Title = "Lobotomi" };
            Experiment ex4 = new Experiment() { Id = 4, Title = "Kautiriasmos" };
            Experiment ex5 = new Experiment() { Id = 5, Title = "Lobotomi" };

            Doctor d1 = new Doctor() { Id = 1, Age = 25, FirstName = "Takis", LastName = "Pantelopoulos", Salary = 40000 };
            Doctor d2 = new Doctor() { Id = 2, Age = 35, FirstName = "Mitsos", LastName = "Silveropoulos", Salary = 38453 };
            Doctor d3 = new Doctor() { Id = 3, Age = 45, FirstName = "Thanos", LastName = "Goldopoulos", Salary = 53453 };
            Doctor d4 = new Doctor() { Id = 4, Age = 55, FirstName = "Kostas", LastName = "Poulopoulos", Salary = 191919 };
            Doctor d5 = new Doctor() { Id = 5, Age = 26, FirstName = "Giorgos", LastName = "Ntouropoulos", Salary = 54534 };

            d1.Experiments = new List<Experiment> { ex1, ex2, ex3 };
            d2.Experiments = new List<Experiment> { ex4, ex5 };

            List<Doctor> doctors = new List<Doctor> { d1, d2, d3, d4, d5 };

            //foreach (var item in doctors.Where(x => x.Age > 30 && x.Salary > 50000))
            //{
            //    item.Output();
            //}

            var lista = doctors.Where(x => x.Age > 30 && x.Salary > 50000);

            var lista2 = doctors.OrderBy(x => x.FirstName);

            var lista3 = doctors.OrderByDescending(x => x.Salary);

            var lista4 = doctors.OrderByDescending(x => x.Salary).ThenBy(x => x.Age);

            Console.WriteLine(lista.Average(x => x.Age));

            var lista5 = from item in doctors
                         where (item.Age > 30)
                         select item;

            foreach (var item in lista5)
            {
                item.Output();
            }


            foreach (var item in lista)
            {
                item.Output();
            }

            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 1, 2, 3 };

            //func pernei 2 int kai epistrefei 1 int
            p1.Aggregate((x, y) => x * y);

            var p = p1.Zip(p2, (x, y) => x + y);

        }
    }

    class Doctor
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public List<Experiment> Experiments { get; set; }

        public void Output()
        {
            Console.WriteLine("Id " + Id);
        }
    }

    class Experiment
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
