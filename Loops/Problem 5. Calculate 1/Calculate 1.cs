using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Calculate_1
{
    class CalculateS
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
            int x = int.Parse(Console.ReadLine());
            double S = 0;
            int counter = 1;
            for (int i = 1; i <= n; i++)
            {
             int x1=Factorial(i);
             S+=x1/Math.Pow(x,counter);
             counter++;
            }
            S += 1;
            Console.WriteLine("{0:0.00000}",S);
        }
    }
}
