using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Multiplication_Sign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            bool isA = false;
            bool isB = false;
            bool isC = false;

            if (a > 0)
            {
                isA = true;
            }
            
            if(b > 0)
            {
                isB = true;
            }
            
            if(c>0)
            {
              isC = true;
            }
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else if(isA==true && isB==true && isC==true)
            {
                Console.WriteLine("+");
            }
            else if ((isA == true && isB == true && isC == false)
                || (isA == true && isC == true && isB == false)
                || (isB == true && isC == true && isA == false))
            {
                Console.WriteLine("-");
            }
            else if (isA == false && isB == false && isC == false)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}
