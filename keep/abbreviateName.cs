using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsAbbreviateName
{
    public class Kata
    {
        public static string AbbrevName(string name)
        {
            //take first letter of name and surname
            string[] nameList = name.Split(' ');
            string firstName = nameList[0];
            string lastName = nameList[1];
            return (firstName[0] + "." + lastName[0]).ToUpper();
        }
    }
}
