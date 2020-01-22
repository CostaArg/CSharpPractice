using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolProject
{
    class Trainer
    {
        private string firstName;
        private string lastName;
        private string subject;

        public static List<Trainer> trainerList = new List<Trainer>();

        public Trainer() { }

        public Trainer(string firstName, string lastName, string subject)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.subject = subject;
        }

        public void setFirstName()
        {
            Console.WriteLine("Please enter your first name: ");
            firstName = Console.ReadLine();
        }

        public string getFirstName()
        {
            return firstName;
        }

        public void setLastName()
        {
            Console.WriteLine("Please enter your last name: ");
            lastName = Console.ReadLine();
        }

        public string getLastName()
        {
            return lastName;
        }

        public void setSubject()
        {
            Console.WriteLine("Please enter your subject: ");
            subject = Console.ReadLine();
        }

        public string getSubject()
        {
            return subject;
        }

        public void printTrainer()
        {
            Console.WriteLine("Your Trainer's first name is: " + getFirstName());
            Console.WriteLine("Your Trainer's last name is: " + getLastName());
            Console.WriteLine("Your Trainer's subject is: " + getSubject());
        }

        public void printTrainerName()
        {
            Console.WriteLine("Your Trainer's name is: " + getFirstName() + " " + getLastName());
        }

        public static void makeTrainer()
        {

            int i = 0;
            string yesOrNo;

            do
            {

                do
                {
                    Console.WriteLine("Do you want to enter a new trainer? Y/N");
                    yesOrNo = Console.ReadLine();
                } while (yesOrNo != "Y" && yesOrNo != "N");

                if (yesOrNo == "Y")
                {
                    trainerList.Add(new Trainer());

                    trainerList[i].setFirstName();
                    trainerList[i].setLastName();
                    trainerList[i].setSubject();
                }

                i++;

            } while (yesOrNo == "Y");

        }

        public static void printAllTrainers()
        {
            string yesOrNo;

            do
            {
                Console.WriteLine("Do you want to print all the assignments? Y/N");
                yesOrNo = Console.ReadLine();
            } while (yesOrNo != "Y" && yesOrNo != "N");

            if (yesOrNo == "Y")
            {
                Console.WriteLine("  --Trainer Names--  ");

                foreach (Trainer onoma in trainerList)
                {
                    onoma.printTrainerName();
                }

            }


        }
    

    }
}
