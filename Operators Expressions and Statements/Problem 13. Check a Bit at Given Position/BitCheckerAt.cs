using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Check_a_Bit_at_Given_Position
{
    class BitCheckerAt
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string bit = Convert.ToString(n, 2);
            int p = int.Parse(Console.ReadLine());
            string zero = "0";

            for (int i = 0; i <= 16 - bit.Length; i++)
            {
                zero += "0";
            }

            zero += bit;
            bit = zero;
            char digit=bit[bit.Length - p - 1];
            bool x= (digit=='1')?true:false;
            Console.WriteLine(x);
        }
    }
}
