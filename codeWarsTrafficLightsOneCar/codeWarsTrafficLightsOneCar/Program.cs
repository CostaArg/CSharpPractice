using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeWarsTrafficLightsOneCar
{
    class Program
    {
        static void Main(string[] args)
        {
            string road = "C...R............G......";
            int n = 10;

            Dinglemouse.TrafficLights(road, n);
        }
    }

    public class Dinglemouse
    {
        public static string[] TrafficLights(string road, int n)
        {
            List<char> roadList = new List<char>();

            roadList.AddRange(road);

            int redLightIndex = 0;

            for (int iter = 0; iter < n; iter++)
            {
                int index = roadList.FindIndex(s => s == 'C');

                roadList[index] = '.';

                if (redLightIndex != 0)
                {
                    roadList[redLightIndex] = 'R';
                    redLightIndex = 0;
                }

                if (roadList[index + 1] == 'R')
                    redLightIndex = index + 1;

                roadList[index + 1] = 'C';

                for (int i = 0; i < roadList.Count; i++)
                {
                    if (roadList[i] == 'O')
                        roadList[i] = 'R';
                }


                if (iter % 5 == 0)
                {
                    for (int i = 0; i < roadList.Count; i++)
                    {
                        if (roadList[i] == 'R')
                            roadList[i] = 'G';
                        else if (roadList[i] == 'G')
                            roadList[i] = 'O';
                    }
                }

                foreach (var item in roadList)
                {
                    Console.Write(item);
                }

                Console.WriteLine();
            }




            return new string[] { "" };
        }
    }
}
