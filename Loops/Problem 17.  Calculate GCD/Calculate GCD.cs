using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17.Calculate_GCD
{
    class CalculateGCD
    {
        public static int gcd(int a, int b)
        {

            while (b != 0)
            {
                int t = b;
                b = a - Math.Abs(b);
                a = t;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = gcd(a, b);
            Console.WriteLine(x);
        }
    }
}
