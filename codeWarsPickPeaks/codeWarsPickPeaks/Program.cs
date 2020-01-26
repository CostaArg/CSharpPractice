using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsPickPeaks
{
    class Program
    {
        static void Main(string[] args)
        { 
        }
    }

    public class PickPeaks
    {
        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            Dictionary<string, List<int>> d1 = new Dictionary<string, List<int>>();

            for (int i = 1; i < arr.Length - 1; i++)
            {
                List<int> intList = new List<int>();
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    d1.Add("pos", i);
                    intList.Add(arr[i]);

                }

            }

        }
    }
}
