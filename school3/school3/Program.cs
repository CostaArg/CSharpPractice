using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school3
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();

            //db.PrintAllStudents();
            //db.PrintAllProjects();
            //db.PrintProjectsPerStudent();
            //db.PrintAllCourses();
            //db.PrintProjectsPerStudent();
            //db.PrintCoursesPerStudent();
            db.PrintCoursesPerStudent();
            db.PrintStudentsPerCourse();

        }
    }

    class Database
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Project> Projects { get; set; } = new List<Project>();
        public List<Course> Courses { get; set; } = new List<Course>();

        public List<ProjectsPerStudent> ProjectsPerStudents { get; set; } = new List<ProjectsPerStudent>();
        public List<StudentCourse> StudentCourseList { get; set; } = new List<StudentCourse>();

        public Database()
        {
            Student s1 = new Student("Hector");
            Student s2 = new Student("Giannis");
            Student s3 = new Student("Panagiotis");
            Student s4 = new Student("Mixalis");
            Student s5 = new Student("Kiriakos");

            Students.Add(s1);
            Students.Add(s2);
            Students.Add(s3);
            Students.Add(s4);
            Students.Add(s5);

            Project p1 = new Project("C#");
            Project p2 = new Project("Java");
            Project p3 = new Project("Python");
            Project p4 = new Project("Javascript");
            Project p5 = new Project("Html");
            Project p6 = new Project("Css");

            Projects.Add(p1);
            Projects.Add(p2);
            Projects.Add(p3);

            List<Project> proj1 = new List<Project>() { p1, p2, p3 };
            ProjectsPerStudent PPS1 = new ProjectsPerStudent(s1, proj1);

            List<Project> proj2 = new List<Project>() { p4 };
            ProjectsPerStudent PPS2 = new ProjectsPerStudent(s2, proj2);

            Course c1 = new Course("Maths", 3000);
            Course c2 = new Course("History", 4500);
            Course c3 = new Course("Physics", 2000);

            Courses.Add(c1);
            Courses.Add(c2);
            Courses.Add(c3);

            ProjectsPerStudents.Add(PPS1);
            ProjectsPerStudents.Add(PPS2);

            StudentCourse SC1 = new StudentCourse(s3, c1);
            StudentCourse SC2 = new StudentCourse(s4, c2);

            StudentCourseList.Add(SC1);
            StudentCourseList.Add(SC2);
        }

        public void PrintProjectsPerStudent()
        {
            foreach (var item in ProjectsPerStudents)
            {
                item.Output();
            }
        }

        public void PrintCoursesPerStudent()
        {
            foreach (var mathima in Courses)
            {
                Console.WriteLine(mathima.Title);
                foreach (var mathiti in mathima.Students)
                {
                    Console.Write("\t");
                    Console.WriteLine(mathiti.FirstName);
                }
                Console.WriteLine("----");
            }
        }

        public void PrintStudentsPerCourse()
        {
            foreach (var mathiti in Students)
            {
                Console.WriteLine(mathiti.FirstName);
                foreach (var mathima in mathiti.Courses)
                {
                    Console.Write("\t");
                    Console.WriteLine(mathima.Title + " " + mathima.Cost);
                }
                Console.WriteLine("----");
            }
        }

        public void PrintAllStudents()
        {
            Console.WriteLine("All Students");
            foreach (var mathitis in Students)
            {
                mathitis.Output();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void PrintAllProjects()
        {
            Console.WriteLine("All Projects");
            foreach (var item in Projects)
            {
                item.Output();
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void PrintAllCourses()
        {
            Console.WriteLine("All Courses");
            foreach (var item in Courses)
            {
                item.Output();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    class Course
    {
        public string Title { get; set; }
        public int Cost { get; set; }

        public List<Student> Students = new List<Student>();

        public Student student { get; set; }

        public List<Course> Courses { get; set; }

        public Course(string title, int cost)
        {
            Title = title;
            Cost = cost;
        }

        public void Output()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Cost);
        }

    }

    class Student
    {
        public string FirstName { get; set; }

        public List<Project> Projects { get; set; } = new List<Project>();

        public List<Course> Courses { get; set; } = new List<Course>();

        public Student(string firstName)
        {
            FirstName = firstName;
        }

        public void Output()
        {
            Console.WriteLine(FirstName);
        }
    }

    class Project
    {
        public string Title { get; set; }

        public Student student { get; set; }

        public Project(string title)
        {
            Title = title;
        }

        public void Output()
        {
            Console.WriteLine(Title);
        }
    }


    class ProjectsPerStudent
    {
        Student mathitis;

        public ProjectsPerStudent(Student student, List<Project> projects)
        {
            mathitis = student;
            student.Projects = projects;
            foreach (var item in projects)
            {
                item.student = student;
            }
        }

        public void Output()
        {
            Console.WriteLine(mathitis.FirstName);
            foreach (var item in mathitis.Projects)
            {
                Console.Write("\t");
                Console.WriteLine(item.Title);
            }
        }
    }

    class StudentCourse
    {
        Student student;

        Course course;

        public StudentCourse(Student student, Course course)
        {
            this.student = student;
            this.course = course;

            student.Courses.Add(course);
            course.Students.Add(student);
        }

        //public void OutputStudents()
        //{
        //    Console.WriteLine(course.Title);
        //    foreach (var item in course.Students)
        //    {
        //        Console.Write("\t");
        //        Console.WriteLine(item.FirstName);
        //    }
        //}

        //public void OutputCourses()
        //{
        //    Console.WriteLine(student.FirstName);
        //    foreach (var item in student.Courses)
        //    {
        //        Console.Write("\t");
        //        Console.WriteLine(item.Title + " " + item.Cost);
        //    }
        //}
    }
}
