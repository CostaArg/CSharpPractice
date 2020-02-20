using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gift
{


    class Person
    {
        //properties
        private string name;
        private string surname;
        private double phonenumber;

        //constructors
        public Person() { }

        public Person(string name, string surname, double phonenumber)
        {
            this.name = name;
            this.surname = surname;
            this.phonenumber = phonenumber;
        }

        //getters & setters
        public string getName()
        {
            return name;
        }

        public string getSurname()
        {
            return surname;
        }

        public double getPhonenumber()
        {
            return phonenumber;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setSurname(string surname)
        {
            if (surname.Length > 3 && string.IsNullOrWhiteSpace(surname))
                this.surname = surname;
        }

        public void setPhonenumber(double phonenumber)
        {
            this.phonenumber = phonenumber;
        }

        //other methods
        public void print()
        {
            Console.WriteLine(name + surname + phonenumber);
        }

    }

    class Present
    {
        private Person p;
        private double cost;
        public Present() { }

        public Present(Person p, double cost)
        {
            this.p = p;
            this.cost = cost;
        }

        public void print()
        {
            Console.WriteLine(p.getName() + " " + p.getSurname() + " with phone number " + p.getPhonenumber() + " will get a present of cost " + cost);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person peter = new Person("peter", "palmer", 2109940596);

            Person john = new Person();
            john.setName("john");
            john.setSurname("brown");
            john.setPhonenumber(399584);

            Person john2 = new Person();
            john2.setName(john.getName());

            Console.WriteLine("Enter " + john2.getName() + "'s surname: ");
            john2.setSurname(Console.ReadLine());

            Present television = new Present(peter, 899.99);
            television.print();
        }

    }


}
