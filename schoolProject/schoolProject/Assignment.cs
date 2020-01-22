using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolProject
{
    class Assignment
    {
        private string title;
        private string description;
        private DateTime subDateTime;
        private string oralMark;
        private string totalMark;

        public static List<Assignment> assignmentList = new List<Assignment>();

        public Assignment() { }

        public Assignment(string title, string description, DateTime subDateTime, string oralMark, string totalMark)
        {
            this.title = title;
            this.description = description;
            this.subDateTime = subDateTime;
            this.oralMark = oralMark;
            this.totalMark = totalMark;
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

        public void setDescription()
        {
            Console.WriteLine("Please enter your description: ");
            description = Console.ReadLine();
        }

        public string getDescription()
        {
            return description;
        }

        public void setSubDateTime()
        {
            Console.WriteLine("Please enter your sub date time: ");
            subDateTime = Convert.ToDateTime(Console.ReadLine());
        }

        public DateTime getSubDateTime()
        {
            return subDateTime;
        }

        public void setOralMark()
        {
            Console.WriteLine("Please enter your oral mark: ");
            oralMark = Console.ReadLine();
        }

        public string getOralMark()
        {
            return oralMark;
        }

        public void setTotalMark()
        {
            Console.WriteLine("Please enter your total mark: ");
            totalMark = Console.ReadLine();
        }

        public string getTotalMark()
        {
            return totalMark;
        }

        public void printAssignment()
        {
            Console.WriteLine("Your Assignment's title is: " + getTitle());
            Console.WriteLine("Your Assignment's description is: " + getDescription());
            Console.WriteLine("Your Assignment's subDateTime is: " + getSubDateTime());
            Console.WriteLine("Your Assignment's oralMark is: " + getOralMark());
            Console.WriteLine("Your Assignment's totalMark is: " + getTotalMark());
        }

        public void printAssignmentName()
        {
            Console.WriteLine("Assignment name: " + getTitle());
        }

        public static void makeAssignment()
        {

            int i = 0;
            string yesOrNo;

            do
            {

                do
                {
                    Console.WriteLine("Do you want to enter a new assignment? Y/N");
                    yesOrNo = Console.ReadLine();
                } while (yesOrNo != "Y" && yesOrNo != "N");

                if (yesOrNo == "Y")
                {
                    assignmentList.Add(new Assignment());

                    assignmentList[i].setTitle();
                    assignmentList[i].setDescription();
                    assignmentList[i].setSubDateTime();
                    assignmentList[i].setOralMark();
                    assignmentList[i].setTotalMark();
                }

                i++;

            } while (yesOrNo == "Y");

        }

        public static void printAllAssignments()
        {
            string yesOrNo;

            do
            {
                Console.WriteLine("Do you want to print all the assignments? Y/N");
                yesOrNo = Console.ReadLine();
            } while (yesOrNo != "Y" && yesOrNo != "N");

            if (yesOrNo == "Y")
            {
                Console.WriteLine("  --Assignment Names--  ");

                foreach (Assignment askisi in assignmentList)
                {
                    askisi.printAssignmentName();
                }

            }


        }
    }

}

