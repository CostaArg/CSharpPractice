using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsHowOld
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

public static class AgeDiff
    {
        public static string CalculateAge(int birth, int yearTo)
        {
            int result = yearTo - birth;
            if (result == 1) return "You are " + result + " year old.";
            else if (result > 0) return "You are " + result + " years old.";
            else if (result == 0) return "You were born this very year!";
            else if (result == -1) return "You will be born in " + Math.Abs(result) + " year.";
            else return "You will be born in " + Math.Abs(result) + " years.";
        }
    }
}
