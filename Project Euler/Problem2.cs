using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem2
    {
        public Problem2()
        {
            int i = 0;
            int j = 1;
            int k = 1;
            int next;


            while (k < 4000000)
            {
                next = j + k;
                j = k;
                k = next;

                if (k % 2 == 0)
                {
                    i += k;
                }
            }
            Console.WriteLine($"The total sum is {i}");
        }
    }
}
