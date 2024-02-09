using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem3
    {
        public Problem3()
        {
            long Target = 600851475143;
            long div = 2;

            while (div * div <= Target)
            {
                if (Target %  div == 0)
                {
                    Target /= div; 
                }
                else
                {
                    ++div;
                }
            }


            Console.WriteLine(Target);

           
        }
    }
}
