using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectFoitites
{

    public class Foititis
    {
        int age;
        string name;
        double tuitionFee;
        DateTime startingDate;
        string phoneNumber;

        public Foititis(int age, string name, double tuitionFee, DateTime startingDate, string phoneNumber)
        {
            this.age = age;
            this.name = name;
            this.tuitionFee = tuitionFee;
            this.startingDate = startingDate;
            this.phoneNumber = phoneNumber;
        }

        public void RaiseFee (double percentage)
        {
            tuitionFee = tuitionFee + (percentage / 100 * tuitionFee);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime thisDate = new DateTime(2398, 12, 15);
            Foititis thanassis = new Foititis(20, "thanassis", 500.98, thisDate, "003040503");
            thanassis.RaiseFee(500);
        }
    }
}
