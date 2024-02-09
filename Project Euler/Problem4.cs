using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem4
    {
        public Problem4()
        {
            int Palindrome = 0, current, rev;

            
            for (int i = 999; i > 100; i--)
            {
                for (int j = 999; j > 100; j--)
                {
                    current = i * j;
                    rev = Reverse(current);
                    if (current == Reverse(current))
                    {
                        if (current > Palindrome)
                        {
                            Palindrome = current;
                        }
                    }
                }
            }
            Console.WriteLine(Palindrome);
        }

        static int Reverse(int number)
        {
            return int.Parse(number.ToString().Reverse().Aggregate("", (s, c) => s + c));
        }
    }
}
