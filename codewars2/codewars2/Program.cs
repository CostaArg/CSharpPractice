using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars2
{

    public class Watermelon
    {
        public static bool? Divide(int w)
        {
            //Do it here bro!
            if (w >= 1 && w <= 100)
            {


                if (w % 2 == 0)
                    return true;
                else
                    return false;

            }

            return null;
        }
    }

}
