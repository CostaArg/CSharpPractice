using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolProject
{
    class Course
    {
        private string title;
        private string stream;
        private string type;
        private DateTime startDate;
        private DateTime endDate;

        public static List<Course> courseList = new List<Course>();

        public Course() { }

        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            this.title = title;
            this.stream = stream;
            this.type = type;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public void setTitle()
        {
            Console.WriteLine("Please enter your title: ");
            title = Console.ReadLine();
        }

        public string getTitle()
        {
            return title;
        }

        public void setStream()
        {
            Console.WriteLine("Please enter your stream: ");
            stream = Console.ReadLine();
        }

        public string getStream()
        {
            return stream;
        }

        public void setType()
        {
            Console.WriteLine("Please enter your type: ");
            type = Console.ReadLine();
        }

        public string getType()
        {
            return type;
        }

        public void setStartDate()
        {
            Console.WriteLine("Please enter your start date: ");
            startDate = Convert.ToDateTime(Console.ReadLine());
        }

        public DateTime getStartDate()
        {
            return startDate;
        }

        public void setEndDate()
        {
            Console.WriteLine("Please enter your end date: ");
            endDate = Convert.ToDateTime(Console.ReadLine());
        }

        public DateTime getEndDate()
        {
            return endDate;
        }

        public void printCourse()
        {
            Console.WriteLine("Your Course's title is: " + getTitle());
            Console.WriteLine("Your Course's stream is: " + getStream());
            Console.WriteLine("Your Course's type is: " + getType());
            Console.WriteLine("Your Course's start date is: " + getStartDate());
            Console.WriteLine("Your Course's end date is: " + getEndDate());
        }

        public static void printAllCourses()
        {
            string yesOrNo;

            do
            {
                Console.WriteLine("Do you want to print all the courses? Y/N");
                yesOrNo = Console.ReadLine();
            } while (yesOrNo != "Y" && yesOrNo != "N");

            if (yesOrNo == "Y")
            {
                Console.WriteLine("  --Course Titles--  ");

                foreach (Course mathima in courseList)
                {
                    mathima.printCourse();
                }
            }
        }

        static void makeCourse()
        {
            int i = 0;
            string yesOrNo;


            do
            {

                do
                {
                    Console.WriteLine("Do you want to enter a new course? Y/N");
                    yesOrNo = Console.ReadLine();
                } while (yesOrNo != "Y" && yesOrNo != "N");

                if (yesOrNo == "Y")
                {
                    courseList.Add(new Course());

                    courseList[i].setTitle();
                    courseList[i].setStream();
                    courseList[i].setType();
                    courseList[i].setStartDate();
                    courseList[i].setEndDate();
                    //Course otinane = new Course(i.getTitle(), getStream(), getType(), getStartDate(), getEndDate());
                    //courseList.Add(otinane);
                }

                i++;

            } while (yesOrNo == "Y");
        }

        static void Main(string[] args)
        {

            Student.makeStudent();
            Student.printAllStudents();
            Assignment.makeAssignment();
            Assignment.printAllAssignments();
            Course.makeCourse();
            Course.printAllCourses();
            Trainer.makeTrainer();
            Trainer.printAllTrainers();

        }
    }
}
