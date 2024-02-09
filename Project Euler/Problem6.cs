using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    public class Problem6
    {
        public Problem6()
        {
            int SumOfSquares = sumNatSquares();
            int SquareOfSums = SquareOfSum();
            Console.WriteLine($"The Sum of the squares is {SumOfSquares} and the Square of Sums is {SquareOfSums}");
            Console.WriteLine(SquareOfSums - SumOfSquares);
        }

        static int sumNatSquares()
        {
            int sum = 0;
            for (int i = 1; i < 101; i++)
            {
                sum += (i * i);
            }
            return sum;
        }

        static int SquareOfSum()
        {
            int sum = 0;
            for (int i = 1; i < 101; i++)
            {
                sum += i;
            }
            return sum * sum;

        }
    }
}
