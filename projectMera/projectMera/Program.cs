using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectMera
{
    class Program
    {
        static void Main(string[] args)
        {
/*            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime hmeromhnia = new DateTime(2403, 11, 23);
            Console.WriteLine(hmeromhnia);*/

            List<DateTime> hmeromhniaList = new List<DateTime>();

            for (int i = 1; i <= 10; i++)
            {
                hmeromhniaList.Add(new DateTime(2034, 10, i));
            }

            foreach (DateTime elem in hmeromhniaList)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
