using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Data data = new Data();

            while (true)
            {
                string option = SelectOption();

                if (option == "1")
                {
                    data.PrintAllStudents();
                    data.PrintAllCourses();
                    data.PrintAllTrainers();
                    data.PrintAllAssignments();
                    data.PrintStudentsPerCourse();
                    data.PrintTrainersPerCourse();
                    data.PrintAssignmentsPerCourse();
                    data.PrintAssignmentsPerStudent();
                    data.PrintMultipleEnrolledStudents();
                    //data.PrintWhatever();
                }
                else if (option == "2")
                {
                    data.MakeStudents();
                }
                else if (option == "3")
                {
                    data.MakeCourses();
                }
                else if (option == "4")
                {
                    data.MakeTrainers();
                }
                else if (option == "5")
                {
                    data.MakeAssignments();
                }
                else if (option == "6")
                {
                    data.PrintStudentsWithDueDate();
                }
                else if (option == "STOP")
                {
                    Environment.Exit(0);
                }
            }
        }

        public static string SelectOption()
        {
            Console.WriteLine("Select an option or enter STOP to exit:");
            Console.WriteLine("1. Print Information");
            Console.WriteLine("2. Enter Student");
            Console.WriteLine("3. Enter Course");
            Console.WriteLine("4. Enter Trainer");
            Console.WriteLine("5. Enter Assignment");
            Console.WriteLine("6. Enter Due Date");
            string option = Console.ReadLine();
            return option;
        }
    }

    class Data
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<StudentPerCourse> StudentsPerCourse { get; set; } = new List<StudentPerCourse>();
        public List<TrainerPerCourse> TrainersPerCourse { get; set; } = new List<TrainerPerCourse>();
        public List<AssignmentPerCourse> AssignmentsPerCourse { get; set; } = new List<AssignmentPerCourse>();
        public List<AssignmentPerStudent> AssignmentsPerStudent { get; set; } = new List<AssignmentPerStudent>();
        public List<CoursePerStudent> CoursesPerStudent { get; set; } = new List<CoursePerStudent>();

        public Data()
        {
            //creating students
            Student s1 = new Student("Giorgos");
            Student s2 = new Student("Thanassis");
            Student s3 = new Student("Dimitris");
            Student s4 = new Student("Giannis");
            Student s5 = new Student("Manolis");

            Students.Add(s1);
            Students.Add(s2);
            Students.Add(s3);
            Students.Add(s4);
            Students.Add(s5);

            //creating courses
            Course c1 = new Course("C++");
            Course c2 = new Course("Assembly");
            Course c3 = new Course("COBOL");

            Courses.Add(c1);
            Courses.Add(c2);
            Courses.Add(c3);

            //creating trainers
            Trainer t1 = new Trainer("Mixalis");
            Trainer t2 = new Trainer("Mitsos");
            Trainer t3 = new Trainer("Spiros");
            Trainer t4 = new Trainer("Stavros");

            Trainers.Add(t1);
            Trainers.Add(t2);
            Trainers.Add(t3);
            Trainers.Add(t4);

            //creating assignments
            Assignment a1 = new Assignment("Project Eshop");
            Assignment a2 = new Assignment("Project Bank");

            Assignments.Add(a1);
            Assignments.Add(a2);

            //creating assignments with dates
            Assignment a3 = new Assignment("Project Library", new DateTime(2020, 01, 02));
            Assignment a4 = new Assignment("Project Lab", new DateTime(2020, 03, 27));
            Assignment a5 = new Assignment("Project School", new DateTime(2020, 03, 24));

            Assignments.Add(a3);
            Assignments.Add(a4);
            Assignments.Add(a5);

            //putting students in mini-lists (students per Course)
            List<Student> C1Stu = new List<Student>();
            List<Student> C2Stu = new List<Student>();
            List<Student> C3Stu = new List<Student>();

            C1Stu.Add(s1);
            C1Stu.Add(s2);

            C2Stu.Add(s1);
            C2Stu.Add(s2);
            C2Stu.Add(s3);

            C3Stu.Add(s2);
            C3Stu.Add(s1);

            //putting mini-lists in big lists (students per Course)
            StudentPerCourse stuPerCour1 = new StudentPerCourse(c1, C1Stu);
            StudentPerCourse stuPerCour2 = new StudentPerCourse(c2, C2Stu);
            StudentPerCourse stuPerCour3 = new StudentPerCourse(c3, C3Stu);

            StudentsPerCourse.Add(stuPerCour1);
            StudentsPerCourse.Add(stuPerCour2);
            StudentsPerCourse.Add(stuPerCour3);

            //putting trainers in mini-lists (trainers per Course)
            List<Trainer> C1Train = new List<Trainer>();
            List<Trainer> C2Train = new List<Trainer>();
            List<Trainer> C3Train = new List<Trainer>();

            C1Train.Add(t1);
            C1Train.Add(t2);

            C2Train.Add(t1);
            C2Train.Add(t3);

            C3Train.Add(t4);
            C3Train.Add(t1);

            //putting mini-lists in big lists (trainers per Course)
            TrainerPerCourse trainPerCour1 = new TrainerPerCourse(c1, C1Train);
            TrainerPerCourse trainPerCour2 = new TrainerPerCourse(c2, C2Train);
            TrainerPerCourse trainPerCour3 = new TrainerPerCourse(c3, C3Train);

            TrainersPerCourse.Add(trainPerCour1);
            TrainersPerCourse.Add(trainPerCour2);
            TrainersPerCourse.Add(trainPerCour3);

            //putting assignments in mini-lists (assignments per Course)
            List<Assignment> C1Assign = new List<Assignment>();
            List<Assignment> C2Assign = new List<Assignment>();

            C1Assign.Add(a2);
            C1Assign.Add(a1);

            C2Assign.Add(a2);

            //putting mini-lists in big lists (assignments per Course)
            AssignmentPerCourse assignPerCour1 = new AssignmentPerCourse(c1, C1Assign);
            AssignmentPerCourse assignPerCour2 = new AssignmentPerCourse(c2, C2Assign);

            AssignmentsPerCourse.Add(assignPerCour1);
            AssignmentsPerCourse.Add(assignPerCour2);

            //putting assignments in mini-lists (assignments per Student)
            List<Assignment> S1Assign = new List<Assignment>();
            List<Assignment> S2Assign = new List<Assignment>();
            List<Assignment> S3Assign = new List<Assignment>();
            List<Assignment> S4Assign = new List<Assignment>();

            S1Assign.Add(a1);
            S1Assign.Add(a2);

            S2Assign.Add(a1);

            S3Assign.Add(a3);
            S3Assign.Add(a5);

            S4Assign.Add(a4);

            //putting mini-lists in big lists (assignments per Student)
            AssignmentPerStudent assignPerStu1 = new AssignmentPerStudent(s1, S1Assign);
            AssignmentPerStudent assignPerStu2 = new AssignmentPerStudent(s2, S2Assign);
            AssignmentPerStudent assignPerStu3 = new AssignmentPerStudent(s3, S3Assign);
            AssignmentPerStudent assignPerStu4 = new AssignmentPerStudent(s4, S4Assign);

            AssignmentsPerStudent.Add(assignPerStu1);
            AssignmentsPerStudent.Add(assignPerStu2);
            AssignmentsPerStudent.Add(assignPerStu3);
            AssignmentsPerStudent.Add(assignPerStu4);

            //putting courses in mini-lists (courses per Student)
            List<Course> S1Cour = new List<Course>();
            List<Course> S2Cour = new List<Course>();
            List<Course> S3Cour = new List<Course>();

            S1Cour.Add(c1);
            S1Cour.Add(c2);
            S1Cour.Add(c3);

            S2Cour.Add(c1);
            S2Cour.Add(c2);
            S2Cour.Add(c3);

            S3Cour.Add(c2);

            //putting mini-lists in big lists (courses per Student)
            CoursePerStudent courPerStu1 = new CoursePerStudent(s1, S1Cour);
            CoursePerStudent courPerStu2 = new CoursePerStudent(s2, S2Cour);
            CoursePerStudent courPerStu3 = new CoursePerStudent(s3, S3Cour);


            CoursesPerStudent.Add(courPerStu1);
            CoursesPerStudent.Add(courPerStu2);
            CoursesPerStudent.Add(courPerStu3);


        }

        public void PrintWhatever()
        {
            foreach (var mathiti in Students)
            {
                Console.WriteLine(mathiti.Name);

                foreach (var mathima in mathiti.Courses)
                {
                    Console.WriteLine(mathima.Title);

                    foreach (var askisi in mathima.Assignments)
                    {
                        Console.Write("\t");
                        askisi.Output();
                    }
                }
            }
        }

        public void PrintAllStudents()
        {
            // All students
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ALL Students");
            foreach (var item in Students)
            {
                item.Output();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");

        }

        public void PrintAllCourses()
        {
            // All Courses
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ALL Courses");
            foreach (var item in Courses)
            {
                item.Output();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintAllTrainers()
        {
            // All trainers
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("ALL Trainers");
            foreach (var item in Trainers)
            {
                item.Output();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");

        }

        public void PrintAllAssignments()
        {
            // All Assignments
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("ALL Assignments");
            foreach (var item in Assignments)
            {
                item.Output();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintStudentsPerCourse()
        {

            //Students Per Course
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Students per Course");
            foreach (var item in StudentsPerCourse)
            {
                item.Output();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintTrainersPerCourse()
        {

            //Trainers Per Course
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Trainers per Course");
            foreach (var item in TrainersPerCourse)
            {
                item.Output();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintAssignmentsPerCourse()
        {

            //Assignments Per Course
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Assignments per Course");
            foreach (var item in AssignmentsPerCourse)
            {
                item.Output();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintAssignmentsPerStudent()
        {

            //Assignments per student
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Assignments per Student");
            foreach (var item in AssignmentsPerStudent)
            {
                item.Output();
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintMultipleEnrolledStudents()
        {

            //Courses per student
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students with more than 1 course");
            foreach (var item in CoursesPerStudent)
            {
                item.Output();
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintStudentsWithDueDate()
        {
            Console.WriteLine("Enter date: ");
            DateTime givenDate = Convert.ToDateTime(Console.ReadLine());

            foreach (var item in AssignmentsPerStudent)
            {
                item.StudentsDue(givenDate);
            }
        }

        public void MakeCourses()
        {
            string flag;

            do
            {

                do
                {
                    Console.WriteLine("Do you want to enter a new course? Y/N");
                    flag = Console.ReadLine();
                } while (flag != "Y" && flag != "N");

                if (flag == "Y")
                {
                    MakeCourse();
                }

            } while (flag == "Y");
        }

        public void MakeCourse()
        {
            Course newCour = new Course();
            Courses.Add(newCour);

            Console.WriteLine("Enter course's title: ");
            newCour.Title = Console.ReadLine();
        }

        public void MakeStudents()
        {
            string flag;

            do
            {
                do
                {
                    Console.WriteLine("Do you want to enter a new student? Y/N");
                    flag = Console.ReadLine();
                } while (flag != "Y" && flag != "N");

                if (flag == "Y")
                {
                    MakeStudent();
                }
                else
                {
                    Program.Menu();
                }

            } while (flag == "Y");
        }
        public void MakeStudent()
        {
            Student newStu = new Student();
            Students.Add(newStu);

            Console.WriteLine("Enter your first name: ");
            newStu.Name = Console.ReadLine();
        }

        public void MakeAssignments()
        {
            string flag;

            do
            {

                do
                {
                    Console.WriteLine("Do you want to enter a new assignment? Y/N");
                    flag = Console.ReadLine();
                } while (flag != "Y" && flag != "N");

                if (flag == "Y")
                {
                    MakeAssignment();
                }

            } while (flag == "Y");
        }

        public void MakeAssignment()
        {
            Assignment newAssign = new Assignment();
            Assignments.Add(newAssign);

            Console.WriteLine("Enter assignment's title: ");
            newAssign.Title = Console.ReadLine();
        }

        public void MakeTrainers()
        {
            string flag;

            do
            {

                do
                {
                    Console.WriteLine("Do you want to enter a new trainer? Y/N");
                    flag = Console.ReadLine();
                } while (flag != "Y" && flag != "N");

                if (flag == "Y")
                {
                    MakeTrainer();
                }

            } while (flag == "Y");
        }

        public void MakeTrainer()
        {
            Trainer newTrain = new Trainer();
            Trainers.Add(newTrain);

            Console.WriteLine("Enter trainer's name: ");
            newTrain.Name = Console.ReadLine();
        }

    }

    class Student
    {
        public string Name { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Course> Courses { get; set; }

        public Student()
        {

        }

        public Student(string name)
        {
            Name = name;
        }

        public void Output()
        {
            Console.WriteLine(Name);
        }
    }

    class Course
    {
        public string Title { get; set; }

        public List<Assignment> Assignments { get; set; }
        public List<Student> Students { get; set; }
        public List<Trainer> Trainers { get; set; }

        public Course()
        {

        }

        public Course(string title)
        {
            Title = title;
        }

        public void Output()
        {
            Console.WriteLine(Title);
        }
    }

    class Trainer
    {
        public string Name { get; set; }

        public Trainer()
        {

        }

        public Trainer(string name)
        {
            Name = name;
        }

        public void Output()
        {
            Console.WriteLine(Name);
        }
    }

    class Assignment
    {
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public Assignment()
        {

        }

        public Assignment(string title)
        {
            Title = title;
        }

        public Assignment(string title, DateTime date)
        {
            Title = title;
            Date = date;
        }

        public void Output()
        {
            Console.WriteLine(Title);
        }
    }

    class StudentPerCourse
    {
        Course Course { get; set; }


        public StudentPerCourse(Course course, List<Student> students)
        {
            Course = course;

            course.Students = students;
        }

        public void Output()
        {
            Console.WriteLine(Course.Title);
            foreach (var item in Course.Students)
            {
                Console.Write("\t");
                item.Output();
            }
        }
    }

    class TrainerPerCourse
    {
        Course Course { get; set; }


        public TrainerPerCourse(Course course, List<Trainer> trainers)
        {
            Course = course;

            course.Trainers = trainers;
        }

        public void Output()
        {
            Console.WriteLine(Course.Title);
            foreach (var item in Course.Trainers)
            {
                Console.Write("\t");
                item.Output();
            }
        }
    }

    class AssignmentPerCourse
    {
        Course Course { get; set; }


        public AssignmentPerCourse(Course course, List<Assignment> assignments)
        {
            Course = course;

            course.Assignments = assignments;
        }

        public void Output()
        {
            Console.WriteLine(Course.Title);
            foreach (var item in Course.Assignments)
            {
                Console.Write("\t");
                item.Output();
            }
        }
    }

    class CoursePerStudent
    {
        Student Student { get; set; }

        public CoursePerStudent(Student student, List<Course> courses)
        {
            Student = student;

            student.Courses = courses;
        }

        public void Output()
        {
            string previous = null;
            foreach (var item in Student.Courses)
            {
                if (previous != Student.Name)
                {
                    previous = Student.Name;
                    Console.WriteLine(Student.Name);
                }

            }
        }
    }

    class AssignmentPerStudent
    {
        Student Student { get; set; }


        public AssignmentPerStudent(Student student, List<Assignment> assignments)
        {
            Student = student;

            student.Assignments = assignments;
        }

        public void Output()
        {
            Console.WriteLine(Student.Name);
            foreach (var item in Student.Assignments)
            {
                Console.Write("\t");
                item.Output();
            }
        }

        public void StudentsDue(DateTime givenDate)
        {

            foreach (var item in Student.Assignments)
            {
                DateTime beginningOfTheWeek = new DateTime(1, 1, 1);
                DateTime endOfTheWeek = new DateTime(1, 1, 1);

                if (givenDate.DayOfWeek == DayOfWeek.Monday)
                {
                    beginningOfTheWeek = givenDate;
                    endOfTheWeek = givenDate.AddDays(4);
                }
                else if (givenDate.DayOfWeek == DayOfWeek.Tuesday)
                {
                    beginningOfTheWeek = givenDate.AddDays(-1);
                    endOfTheWeek = givenDate.AddDays(3);
                }
                else if (givenDate.DayOfWeek == DayOfWeek.Wednesday)
                {
                    beginningOfTheWeek = givenDate.AddDays(-2);
                    endOfTheWeek = givenDate.AddDays(2);
                }
                else if (givenDate.DayOfWeek == DayOfWeek.Thursday)
                {
                    beginningOfTheWeek = givenDate.AddDays(-3);
                    endOfTheWeek = givenDate.AddDays(1);
                }
                else if (givenDate.DayOfWeek == DayOfWeek.Friday)
                {
                    beginningOfTheWeek = givenDate.AddDays(-4);
                    endOfTheWeek = givenDate;
                }
                else if (givenDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    beginningOfTheWeek = givenDate.AddDays(-5);
                    endOfTheWeek = givenDate.AddDays(-1);
                }
                else if (givenDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    beginningOfTheWeek = givenDate.AddDays(-6);
                    endOfTheWeek = givenDate.AddDays(-2);
                }

                if (beginningOfTheWeek <= item.Date && endOfTheWeek >= item.Date)
                {
                    Console.WriteLine(Student.Name);
                    break;
                }

            }
        }
    }
}
