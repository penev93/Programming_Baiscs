using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_18.Trailing_Zeroes_in_N_
{
    class TrailingZeroesinN
    {
        public static long Factorial(long i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string x = Factorial(n).ToString();

            int counter=0;
            for (int i = x.Length-1; i >=0; i--)
            {
                if(x[i]=='0')
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
