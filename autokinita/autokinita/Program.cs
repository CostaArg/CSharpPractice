using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autokinita
{

    class Car
    {
        private string brand;
        private int year;
        private Engine eng;
        private List<Human> seats = new List<Human>();

        public Car() { }

        public Car(string brand, int year, Engine eng)
        {
            this.brand = brand;
            this.year = year;
            this.eng = eng;
        }

        public void setBrand(string brand)
        {
            this.brand = brand;
        }

        public void setYear(int year)
        {
            this.year = year;

        }

        public void setEng(Engine eng)
        {
            this.eng = eng;
        }

        public string getBrand()
        {
            return brand;
        }

        public int getYear()
        {
            return year;
        }

        public Engine getEng()
        {
            return eng;
        }

/*        public Human getHumanInCar()
        {

        }*/

        public void setHumanInCar(Human h)
        {
            if (seats.Count <= 3)
            {
                seats.Add(h);
                Console.WriteLine("Added " + h.getName() + " to car");
            }
            else
            {
                Console.WriteLine("The car is full, " + h.getName() + " can't come in");
            }
        }

    }

    class Engine
    {        
        private double kw;
        private int ps;

        public Engine() { }

        public Engine (double kw, int ps)
        {
            this.kw = kw;
            this.ps = ps;
        }

        public double getKw()
        {
            return kw;
        }

        public void setKw(double kw)
        {
            this.kw = kw;
        }

        public int getPs()
        {
            return ps;

        }

        public void setPs(int ps)
        {
            this.ps = ps;
        }

    }

    class Human
    {
        private string name;

        public Human() { }

        public Human (string name)
        {
            this.name = name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car(); // eng, list humans, brand, year

            Engine e1 = new Engine(); // kw, ps

            Engine e2 = new Engine();

            e2.setKw(5.0);
            e2.setPs(4);

/*            Human h1 = new Human("xenofontas");
            Human h2 = new Human("vaggelis");
            Human h3 = new Human("eleni");
            Human h4 = new Human("kostas");
            Human h5 = new Human("giannis");

            c1.setHumanInCar(h1);
            c1.setHumanInCar(h2);
            c1.setHumanInCar(h3);
            c1.setHumanInCar(h4);
            c1.setHumanInCar(h5);*/

            c1.setEng(e1);

            c1.getEng().setKw(2.3); //e1.setKw(2.3);

            Car c2 = new Car("Mercedes", 2018, e2);

            c2.getEng().setKw(4);

            Car c3 = new Car();
            Engine e3 = new Engine();

            c3.setEng(e3);

           //bale ta kw ths mhxanhs tou c1 sthn mhxanh tou c3

            c3.getEng().setKw(c1.getEng().getKw());
            
        }
    }

}
