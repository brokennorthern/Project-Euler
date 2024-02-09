using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem5
    {
        public Problem5()
        {
            int i = 1;
            while (true)
            {
                if (i % 20 == 0 && i % 19 == 0 && i % 18 == 0 && i % 17 == 0 && i % 16 == 0 && i % 15 == 0 && i % 14 == 0 && i % 13 == 0 && i % 12 == 0 && i % 11 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
                i++;
            }
        }
    }
}
