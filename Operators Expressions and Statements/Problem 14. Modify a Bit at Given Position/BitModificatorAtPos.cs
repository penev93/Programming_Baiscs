using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Modify_a_Bit_at_Given_Position
{
    class BitModificatorAtPos
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
            char digit = bit[bit.Length - p - 1];
            char x = (digit == '1') ? '0' : '1';


            char[] arr = bit.ToCharArray();
            arr[bit.Length - p - 1] = x;
            string res = "";
            for (int i = 0; i < arr.Length; i++)
            {
                res += arr[i];
            }
            int output = Convert.ToInt32(res,2);

            Console.WriteLine(output);
        }
    }
}
