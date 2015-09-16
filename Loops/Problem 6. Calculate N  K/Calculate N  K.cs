using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Calculate_N__K
{
    class CalculateNK
    {
     /*   public static int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
      */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int nn = 1;
            int kk = 1;
            int ko = k;
            for (int i = n; i > 0; i--)
            {
                nn *= i;

                if (ko != 0)
                {
                    kk *= ko;
                    ko -= 1;
                }

            }
            //int nFac = Factorial(n);
            //int kFac = Factorial(k);

            //  int res = nFac / kFac;

            int secRes = nn / kk;
            //   Console.WriteLine(res);
            Console.WriteLine(secRes);
        }
    }
}
