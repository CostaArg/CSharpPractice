//doesn't work

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsFilterList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> things = new List<object> { 4, 3, "potato", "123" };
            ListFilterer.GetIntegersFromList(things);
        }
    }

    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            for (int i = 0; i < listOfItems.Count; i++)
            {
                if (listOfItems[i].GetType() is string)
                {
                    listOfItems.RemoveAt(i);
                }
            }


        }
    }
}
