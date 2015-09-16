using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Calculate_N_
{
    class CalculateFact
    {
        public static int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int n1 = Factorial(n);
            int k1 = Factorial(k);

            int res = n1 / (k1 * (Factorial(n - k)));
            Console.WriteLine(res);
        }
    }
}
