using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peiramataEntity
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student() { Name = "Vlassis" };
            Student s2 = new Student() { Name = "Marigo" };
            Student s3 = new Student() { Name = "Roulis" };

            Course c1 = new Course() { Title = "HTML" };
            Course c2 = new Course() { Title = "CSS" };
            Course c3 = new Course() { Title = "Ruby" };

            s1.Course.Add(c1);


            using (TsirkoEntities db = new TsirkoEntities())
            {
                db.Student.Add(s1);
                db.SaveChanges();

            }


        }
    }

    class Services
    {

        public static void PrintAllStudentsPerProject()
        {

            using (TsirkoEntities db = new TsirkoEntities())
            {

            }
        }
    }

    class ProgramPalio
    {
        static void Main(string[] args)
        {
            using (TsirkoEntities db = new TsirkoEntities())
            {
                //foreach (var item in db.Student.Where(x => x.Name.StartsWith("H")))

                foreach (var item in db.Student)
                {
                    Console.WriteLine(item.Name);

                    foreach (var item2 in item.Course)
                    {
                        Console.Write("\t");
                        Console.WriteLine(item2.Title);
                    }
                }
            }

        }
    }

}
