using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem1
    {
        public Problem1()
        {
            int i = 0;

            for(int j = 3; j < 1000; j++)
            {
                if (j % 3 == 0 || j % 5 == 0)
                {
                    i += j;
                }
            }
            Console.WriteLine($"The total sum is {i}");
        }
    }
}
