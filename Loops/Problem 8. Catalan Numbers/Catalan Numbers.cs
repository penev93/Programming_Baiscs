using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Catalan_Numbers
{
    class Catalan
    {
        public static long Factorial(long i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long fact = Factorial(n);
            long fact1 = Factorial(2*n);
            long fact2 = Factorial(n + 1);

            long c = fact1 / (fact2 * fact);

            Console.WriteLine(c);
        }
    }
}
