using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem7
    {
        public Problem7()
        {
            int i = 1;
            int count = 0;
            while (true)
            {
                Console.WriteLine(i);
                if(IsPrime(i))
                {
                    count++;
                    Console.WriteLine($"The Count is now {count} and i is currently at {i}");
                }
                if (count > 10000)
                {
                    Console.WriteLine($"The 10001st prime is {i}");
                    break;
                }
                i++;
            } 
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
