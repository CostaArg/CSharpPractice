using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsReturnEven
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class NoOddities
    {
        public static int[] NoOdds(int[] values)
        {
            List<int> valueList = new List<int>();

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                    valueList.Add(values[i]);
            }

            int[] pinakas;

            pinakas = valueList.ToArray();

            return pinakas;
        }
    }
}
