using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsGradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata.GetGrade(70, 71, 72);
        }
    }

public class Kata
    {
        public static char GetGrade(int s1, int s2, int s3)
        {
            double total = (s1 + s2 + s3) / 3;
            char grade;

            if (total >= 90 && total <= 100)
                grade = 'A';
            else if (total >= 80 && total < 90)
                grade = 'B';
            else if (total >= 70 && total < 80)
                grade = 'C';
            else if (total >= 60 && total < 70)
                grade = 'D';
            else
                grade = 'F';

            return grade;
        }
    }
}
