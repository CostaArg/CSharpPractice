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
                    //data.PrintACS();
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
        public List<AssignmentCourseStudent> ACSList { get; set; } = new List<AssignmentCourseStudent>();

        public Data()
        {
            //creating students
            Student s1 = new Student("Panagiotis", "Grigoriou", new DateTime(1987, 3, 4), 3000);
            Student s2 = new Student("Konstantinos", "Pantelidis", new DateTime(1991, 6, 2), 4000);
            Student s3 = new Student("Spiros", "Aggelatos", new DateTime(1996, 4, 7), 3500);
            Student s4 = new Student("Dimitris", "Pantelopoulos", new DateTime(2000, 5, 2), 6200);
            Student s5 = new Student("Antonis", "Mixelakakis", new DateTime(1989, 10, 3), 5800);

            Students.Add(s1);
            Students.Add(s2);
            Students.Add(s3);
            Students.Add(s4);
            Students.Add(s5);

            //creating courses
            Course c1 = new Course("Javascript", "Web Development", "Practical Subject", new DateTime(2020, 1, 10), new DateTime(2020, 3, 11));
            Course c2 = new Course("C++", "Object-Oriented Programming", "Practical Subject", new DateTime(2020, 1, 18), new DateTime(2020, 4, 2));
            Course c3 = new Course("Pascal", "Procedural Programming", "Theoretical Subject", new DateTime(2020, 2, 15), new DateTime(2020, 5, 20));
            Course c4 = new Course("Visual Basic", "Windows Application Development", "Practical Subject", new DateTime(2020, 3, 20), new DateTime(2020, 6, 1));

            Courses.Add(c1);
            Courses.Add(c2);
            Courses.Add(c3);
            Courses.Add(c4);

            //creating trainers
            Trainer t1 = new Trainer("Giannis", "Aggelopoulos", "Object-Oriented Programming");
            Trainer t2 = new Trainer("Manolis", "Daskalakis", "Procedural Programming");
            Trainer t3 = new Trainer("Giorgos", "Mpatzoglou", "Procedural Programming");
            Trainer t4 = new Trainer("Thanassis", "Giorgakopoulos", "Object-Oriented Programming");

            Trainers.Add(t1);
            Trainers.Add(t2);
            Trainers.Add(t3);
            Trainers.Add(t4);

            //creating assignments
            Assignment a1 = new Assignment("Project Bank", "Banking application for android phones", new DateTime(2020, 4, 24), 40, 200);
            Assignment a2 = new Assignment("Project E-shop", "Shopping website", new DateTime(2020, 6, 11), 20, 100);
            Assignment a3 = new Assignment("Project Library", "Book rental service", new DateTime(2020, 4, 15), 35, 200);
            Assignment a4 = new Assignment("Project Cinema", "Movie distribution to cinemas", new DateTime(2020, 1, 2), 73, 100);
            Assignment a5 = new Assignment("Project Stocks", "Stock change notifications", new DateTime(2020, 3, 27), 110, 200);
            Assignment a6 = new Assignment("Project Architecture", "Blueprint making software", new DateTime(2020, 3, 24), 40, 150);

            Assignments.Add(a1);
            Assignments.Add(a2);
            Assignments.Add(a3);
            Assignments.Add(a4);
            Assignments.Add(a5);
            Assignments.Add(a6);

            //putting students in mini-lists (students per Course)
            List<Student> C1Stu = new List<Student>();
            List<Student> C2Stu = new List<Student>();
            List<Student> C3Stu = new List<Student>();

            C1Stu.Add(s2);
            C1Stu.Add(s3);

            C2Stu.Add(s1);
            C2Stu.Add(s2);
            C2Stu.Add(s3);

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
            List<Assignment> C3Assign = new List<Assignment>();

            C1Assign.Add(a1);
            C1Assign.Add(a2);

            C2Assign.Add(a3);

            C3Assign.Add(a5);
            C3Assign.Add(a4);

            //putting mini-lists in big lists (assignments per Course)
            AssignmentPerCourse assignPerCour1 = new AssignmentPerCourse(c1, C1Assign);
            AssignmentPerCourse assignPerCour2 = new AssignmentPerCourse(c2, C2Assign);
            AssignmentPerCourse assignPerCour3 = new AssignmentPerCourse(c3, C2Assign);

            AssignmentsPerCourse.Add(assignPerCour1);
            AssignmentsPerCourse.Add(assignPerCour2);
            AssignmentsPerCourse.Add(assignPerCour3);

            //putting assignments in mini-lists (assignments per Student)
            List<Assignment> S1Assign = new List<Assignment>();
            List<Assignment> S2Assign = new List<Assignment>();
            List<Assignment> S3Assign = new List<Assignment>();

            S1Assign.Add(a1);
            S1Assign.Add(a2);

            S2Assign.Add(a3);
            S2Assign.Add(a4);
            S2Assign.Add(a5);

            S3Assign.Add(a6);

            //putting mini-lists in big lists (assignments per Student)
            AssignmentPerStudent assignPerStu1 = new AssignmentPerStudent(s1, S1Assign);
            AssignmentPerStudent assignPerStu2 = new AssignmentPerStudent(s2, S2Assign);
            AssignmentPerStudent assignPerStu3 = new AssignmentPerStudent(s3, S3Assign);

            AssignmentsPerStudent.Add(assignPerStu1);
            AssignmentsPerStudent.Add(assignPerStu2);
            AssignmentsPerStudent.Add(assignPerStu3);

            //putting courses in mini-lists (courses per Student)
            List<Course> S1Cour = new List<Course>();
            List<Course> S2Cour = new List<Course>();
            List<Course> S3Cour = new List<Course>();

            S1Cour.Add(c2);
            S1Cour.Add(c3);


            S2Cour.Add(c1);
            S2Cour.Add(c2);

            S3Cour.Add(c1);
            S3Cour.Add(c2);

            //putting mini-lists in big lists (courses per Student)
            CoursePerStudent courPerStu1 = new CoursePerStudent(s1, S1Cour);
            CoursePerStudent courPerStu2 = new CoursePerStudent(s2, S2Cour);
            CoursePerStudent courPerStu3 = new CoursePerStudent(s3, S3Cour);


            CoursesPerStudent.Add(courPerStu1);
            CoursesPerStudent.Add(courPerStu2);
            CoursesPerStudent.Add(courPerStu3);

            //-------------------------------------------------------

            //AssignmentCourseStudent ACS1 = new AssignmentCourseStudent(s1, c2, a3);
            //AssignmentCourseStudent ACS2 = new AssignmentCourseStudent(s1, c3, a6);
            //AssignmentCourseStudent ACS3 = new AssignmentCourseStudent(s2, c1, a1);
            //AssignmentCourseStudent ACS4 = new AssignmentCourseStudent(s2, c2, a4);
            //AssignmentCourseStudent ACS5 = new AssignmentCourseStudent(s3, c1, a2);
            //AssignmentCourseStudent ACS6 = new AssignmentCourseStudent(s3, c2, a5);

            //ACSList.Add(ACS1);
            //ACSList.Add(ACS2);
            //ACSList.Add(ACS3);
            //ACSList.Add(ACS4);
            //ACSList.Add(ACS5);
            //ACSList.Add(ACS6);
        }

        public void PrintAllStudents()
        {
            // All students
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ALL Students");
            Console.WriteLine();
            foreach (var item in Students)
            {
                item.Output();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");

        }

        public void PrintAllCourses()
        {
            // All Courses
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ALL Courses");
            Console.WriteLine();
            foreach (var item in Courses)
            {
                item.Output();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintAllTrainers()
        {
            // All trainers
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("ALL Trainers");
            Console.WriteLine();
            foreach (var item in Trainers)
            {
                item.Output();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");

        }

        public void PrintAllAssignments()
        {
            // All Assignments
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("ALL Assignments");
            Console.WriteLine();
            foreach (var item in Assignments)
            {
                item.Output();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintStudentsPerCourse()
        {

            //Students Per Course
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Students per Course");
            Console.WriteLine();
            foreach (var item in StudentsPerCourse)
            {
                item.Output();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintTrainersPerCourse()
        {
            //Trainers Per Course
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Trainers per Course");
            Console.WriteLine();
            foreach (var item in TrainersPerCourse)
            {
                item.Output();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintAssignmentsPerCourse()
        {

            //Assignments Per Course
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Assignments per Course");
            Console.WriteLine();
            foreach (var item in AssignmentsPerCourse)
            {
                item.Output();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintAssignmentsPerStudent()
        {

            //Assignments per student
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Assignments per Student");
            Console.WriteLine();
            foreach (var item in AssignmentsPerStudent)
            {
                item.Output();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintMultipleEnrolledStudents()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Students with more than 1 course");
            Console.WriteLine();
            foreach (var item in CoursesPerStudent)
            {
                item.PrintDuplicates();
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintStudentsWithDueDate()
        {

            Console.WriteLine("Enter date yyyy-mm-dd : ");
            string givenDate = Console.ReadLine();
            if (DateTime.TryParse(givenDate, out DateTime correctDate))
            {

            }
            else
            {
                Console.WriteLine("Error: Date could not be parsed");
                Console.WriteLine("Will put synthetic data");
                correctDate = new DateTime(2020, 3, 25);
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Students with due assignments during the week of " + correctDate.ToShortDateString() + ":");
            foreach (var item in AssignmentsPerStudent)
            {
                item.StudentsDue(correctDate);
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
        }

        public void PrintACS()
        {
            string previous = null;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("All students in tree form");
            Console.WriteLine();
            foreach (var item in ACSList)
            {
                previous = item.Output(previous);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------");
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


            } while (flag == "Y");
        }
        public void MakeStudent()
        {
            Student newStu = new Student();
            Students.Add(newStu);

            Console.WriteLine("Enter student's first name: ");
            newStu.FirstName = Console.ReadLine();

            if (newStu.FirstName.Length < 1)
            {
                Console.WriteLine("First name was left empty");
                Console.WriteLine("Will put synthetic data");
                newStu.FirstName = "Basilis";
            }

            Console.WriteLine("Enter student's last name: ");
            newStu.LastName = Console.ReadLine();

            if (newStu.LastName.Length < 1)
            {
                Console.WriteLine("Last name was left empty");
                Console.WriteLine("Will put synthetic data");
                newStu.LastName = "Karantonis";
            }

            try
            {
                Console.WriteLine("Enter student's date of birth yyyy-mm-dd : ");
                newStu.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Will put synthetic data");
                newStu.DateOfBirth = new DateTime(1995, 11, 20);
            }

            try
            {
                Console.WriteLine("Enter student's tuition fees: ");
                newStu.TuitionFees = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Will put synthetic data");
                newStu.TuitionFees = 1000;
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

            if (newCour.Title.Length < 1)
            {
                Console.WriteLine("Title was left empty");
                Console.WriteLine("Will put synthetic data");
                newCour.Title = "HTML";
            }

            Console.WriteLine("Enter course's stream: ");
            newCour.Stream = Console.ReadLine();

            if (newCour.Stream.Length < 1)
            {
                Console.WriteLine("Stream was left empty");
                Console.WriteLine("Will put synthetic data");
                newCour.Stream = "Web Development";
            }

            Console.WriteLine("Enter course's type: ");
            newCour.Type = Console.ReadLine();

            if (newCour.Type.Length < 1)
            {
                Console.WriteLine("Type was left empty");
                Console.WriteLine("Will put synthetic data");
                newCour.Type = "Practical Subject";
            }

            try
            {
                Console.WriteLine("Enter course's start date: ");
                newCour.StartDate = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Will put synthetic data");
                newCour.StartDate = new DateTime(2020, 5, 10);
            }

            try
            {
                Console.WriteLine("Enter course's end date: ");
                newCour.EndDate = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Will put synthetic data");
                newCour.EndDate = new DateTime(2020, 11, 22);
            }

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

            Console.WriteLine("Enter trainer's first name: ");
            newTrain.FirstName = Console.ReadLine();

            if (newTrain.FirstName.Length < 1)
            {
                Console.WriteLine("First name was left empty");
                Console.WriteLine("Will put synthetic data");
                newTrain.FirstName = "Xaralampos";
            }

            Console.WriteLine("Enter trainer's last name: ");
            newTrain.LastName = Console.ReadLine();

            if (newTrain.LastName.Length < 1)
            {
                Console.WriteLine("Last name was left empty");
                Console.WriteLine("Will put synthetic data");
                newTrain.LastName = "Lampropoulos";
            }

            Console.WriteLine("Enter trainer's subject: ");
            newTrain.Subject = Console.ReadLine();

            if (newTrain.Subject.Length < 1)
            {
                Console.WriteLine("Subject was left empty");
                Console.WriteLine("Will put synthetic data");
                newTrain.Subject = "UNIX Systems";
            }

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

            if (newAssign.Title.Length < 1)
            {
                Console.WriteLine("Title was left empty");
                Console.WriteLine("Will put synthetic data");
                newAssign.Title = "Project Chat";
            }

            Console.WriteLine("Enter assignment's description: ");
            newAssign.Description = Console.ReadLine();

            if (newAssign.Description.Length < 1)
            {
                Console.WriteLine("Description was left empty");
                Console.WriteLine("Will put synthetic data");
                newAssign.Description = "Online messaging system";
            }

            try
            {
                Console.WriteLine("Enter assignment's sub date time: ");
                newAssign.SubDateTime = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Will put synthetic data");
                newAssign.SubDateTime = new DateTime(2020, 10, 4);
            }

            try
            {
                Console.WriteLine("Enter assignment's oral mark: ");
                newAssign.OralMark = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Will put synthetic data");
                newAssign.OralMark = 10;
            }

            try
            {
                Console.WriteLine("Enter assignment's total mark: ");
                newAssign.TotalMark = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Will put synthetic data");
                newAssign.TotalMark = 100;
            }

        }

    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int TuitionFees { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Course> Courses { get; set; }

        public Student()
        {

        }

        public Student(string firstname, string lastname, DateTime dateofbirth, int tuitionfees)
        {
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dateofbirth;
            TuitionFees = tuitionfees;
        }

        public void Output()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(DateOfBirth.ToShortDateString());
            Console.WriteLine(TuitionFees);
        }
    }

    class Course
    {
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Student> Students { get; set; }
        public List<Trainer> Trainers { get; set; }

        public Course()
        {

        }

        public Course(string title, string stream, string type, DateTime startdate, DateTime enddate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startdate;
            EndDate = enddate;
        }

        public void Output()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Stream);
            Console.WriteLine(Type);
            Console.WriteLine(StartDate.ToShortDateString());
            Console.WriteLine(EndDate.ToShortDateString());
        }
    }

    class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public Trainer()
        {

        }

        public Trainer(string firstname, string lastname, string subject)
        {
            FirstName = firstname;
            LastName = lastname;
            Subject = subject;
        }

        public void Output()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(Subject);
        }
    }

    class Assignment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public double OralMark { get; set; }
        public double TotalMark { get; set; }

        public Assignment()
        {

        }

        public Assignment(string title, string description, DateTime subdatetime, double oralmark, double totalmark)
        {
            Title = title;
            Description = description;
            SubDateTime = subdatetime;
            OralMark = oralmark;
            TotalMark = totalmark;
        }

        public void Output()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine(SubDateTime.ToShortDateString());
            Console.WriteLine(OralMark);
            Console.WriteLine(TotalMark);
        }

        public void OutputTitle()
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
                Console.WriteLine();
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
                Console.WriteLine();
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
                Console.WriteLine();
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

        public void PrintDuplicates()
        {
            string previous = null;
            foreach (var item in Student.Courses)
            {
                if (previous != Student.FirstName)
                {
                    previous = Student.FirstName;
                    Student.Output();
                }

            }
        }

        public void Output()
        {
            Console.WriteLine(Student.FirstName);
            foreach (var item in Student.Courses)
            {
                Console.Write("\t");
                item.Output();
                foreach (var item2 in Student.Assignments)
                {
                    Console.Write("\t");
                    item2.Output();
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
            Console.WriteLine(Student.FirstName + " " + Student.LastName);
            foreach (var item in Student.Assignments)
            {
                Console.WriteLine();
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

                if (beginningOfTheWeek <= item.SubDateTime && endOfTheWeek >= item.SubDateTime)
                {
                    Console.WriteLine(Student.FirstName);
                    break;
                }

            }
        }
    }

    class AssignmentCourseStudent
    {
        Student Student;

        Course Course;

        Assignment Assignment;

        public AssignmentCourseStudent(Student student, Course course, Assignment assignment)
        {
            Student = student;
            Course = course;
            Assignment = assignment;

            student.Courses.Add(course);
            course.Students.Add(student);

            student.Assignments.Add(assignment);
            course.Assignments.Add(assignment);
        }

        public string Output(string previous)
        {

            if (previous != Student.FirstName)
            {
                Console.WriteLine(Student.FirstName);
            }

            Console.Write("\t");
            Console.WriteLine(Course.Title);

            foreach (var item in Course.Assignments)
            {
                Console.Write("\t\t");
                item.OutputTitle();
            }

            return Student.FirstName;

        }
    }

}
