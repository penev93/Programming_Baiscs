using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16.Decimal_to_Hexadecimal_Number
{
    class DecimaltoHexadecimalNumber
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            
            int remainder = 0;
            List<int> bin = new List<int>();
            while (n >= 1)
            {
                remainder = (int)(n % 16);
                bin.Add(remainder);
                n /= 16;
            }
            bin.Reverse();
            foreach (var item in bin)
            {
                switch (item)
                {
                    case 1: Console.Write(item); break;
                    case 2: Console.Write(item); break;
                    case 3: Console.Write(item); break;
                    case 4: Console.Write(item); break;
                    case 5: Console.Write(item); break;
                    case 6: Console.Write(item); break;
                    case 7: Console.Write(item); break;
                    case 8: Console.Write(item); break;
                    case 9: Console.Write(item); break;
                    case 10: Console.Write("A"); break;
                    case 11: Console.Write("B"); break;
                    case 12: Console.Write("C"); break;
                    case 13: Console.Write("D"); break;
                    case 14: Console.Write("E"); break;
                    case 15: Console.Write("F"); break;
                    
                    default:
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
