using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximize_Distance_to_Closest_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            var seats = new int[] { 1, 0, 0, 0, 1, 0, 1 }; // 0,0,0,0,1 // 0, 0, 1, 0, 0, 0, 1, 0, 0, 0 // [1,0,0,0,1,0,1] // 1,0,0,0
            Console.WriteLine(MaxDistToClosest(seats));
        }

        static int MaxDistToClosest(int[] seats)
        {
            int l = -1;
            int length = seats.Length;
            int max = int.MinValue;
            for (int i = 0; i < length; i++)
            {
                if (seats[i] == 1)
                {
                    if (l == -1) max = i;
                    else
                    {
                        max = Math.Max(max, (i - l) / 2);
                    }
                    l = i;
                }
            }
            if (seats[length - 1] == 0) max = Math.Max(max, length - 1 - l);
            return max;
        }
    }
}
