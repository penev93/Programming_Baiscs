using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Extract_Bit_from_Integer
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string bit = Convert.ToString(n, 2);
            string zero = "";
            for (int i = 0; i <= 16 - bit.Length; i++)
            {
                zero += "0";
            }
            zero += bit;
            bit = zero;
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(bit[bit.Length-p-1]);
        }
    }
}
