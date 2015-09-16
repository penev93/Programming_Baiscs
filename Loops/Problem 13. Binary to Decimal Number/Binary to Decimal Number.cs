using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Binary_to_Decimal_Number
{
    class BinarytoDecimalNumber
    {
        static void Main(string[] args)
        {
              string line;
        int bin = 0;
        int dec = 0;
        int value = 0;

        while (true) 
        {
         
            line = Console.ReadLine();
            bin = int.Parse(line);
            if (line == "exit") 
            {
                 break;
            }
            int bitPos = 0;
            while (bitPos < line.Length )
            {
                value = bin % 10;
                bin = bin / 10;
                dec = dec + value * ((int)Math.Pow(2, bitPos));
                 bitPos ++;
            }
            Console.WriteLine(dec);
            
            }
        }
    }
}
