using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Bitwise_Extract_Bit_3
{
    class ExtractBitThree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string x = Convert.ToString(n, 2);
            string zero = "";
            
            for (int i = 0; i <= 16-x.Length; i++)
            {
                zero+="0";
            }

             zero+=x;
             x = zero;
            string thirdBit = x.Substring(x.Length - 4, 1);
            Console.WriteLine(thirdBit);
        }
    }
}
