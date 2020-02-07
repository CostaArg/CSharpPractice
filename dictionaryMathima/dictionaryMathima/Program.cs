using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryMathima
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> mitsos = new Dictionary<int, string>();

            mitsos[0] = "Xenophon";
            mitsos[1] = "Xenophon";
            mitsos[2] = "Panos";
            mitsos[3] = "Zach";

            Console.WriteLine(mitsos.ContainsKey(3)); //if mitsos has id equals to 3 it returns true

            Dictionary<int, Student> mitsos2 = new Dictionary<int, Student>();

            Student s1 = new Student() { Id = 1, Name = "Thanos", Salary = 4000 };

            mitsos2.Add(s1.Id, s1); //find by id

            mitsos2.Any(x => x.Key == 3); //find the student that has id equals to 3

            int a = 2;
            if (mitsos2.Any(x => x.Key == a))
                Console.WriteLine(mitsos2[a].Name);
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
