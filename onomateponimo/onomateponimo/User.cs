using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onomateponimo
{
    class User
    {
        public string firstName;
        public string lastName;
        public string fullName()
        {
            return firstName + " " + lastName;
        }
    }
}
