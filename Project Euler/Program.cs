using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Euler
{
    class Program
    {
        static void Main()
        {
            var sw = new System.Diagnostics.Stopwatch();
            var problem = new Problem9();
            
            Console.WriteLine($"Execution time: {sw.Elapsed}"); 
        }
    }
}
