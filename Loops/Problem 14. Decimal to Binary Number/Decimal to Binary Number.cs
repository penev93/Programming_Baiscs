using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Decimal_to_Binary_Number
{
    class DecimaltoBinaryNumber
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int remainder = 0;
            List<int> bin=new List<int>();
            while (n>=1)
            {
                remainder =(int)(n % 2);
                bin.Add(remainder);
                n /= 2;
            }
            bin.Reverse();
            foreach (var item in bin)
            {
                Console.Write(item);
            }
        }
    }
}
