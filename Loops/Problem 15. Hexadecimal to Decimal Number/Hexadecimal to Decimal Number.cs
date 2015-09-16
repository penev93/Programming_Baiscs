using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Hexadecimal_to_Decimal_Number
{
    class HexadecimaltoDecimalNumber
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            
            double dec = 0;
            int count=0;
            double doubleUp = 1;

            int xa=00;
            for (int i = hex.Length - 1; i >= 0; i--)
                {
                    int a = 0;
                    if(int.TryParse(hex[i].ToString(),out xa))
                    {
                        a = int.Parse(hex[i].ToString());
                    }
                    else
                    {

                    }
                    switch (hex[i])
                    {
                        case '1': dec += a * doubleUp; break;
                        case '2': dec += a * doubleUp; break;
                        case '3': dec += a * doubleUp; break;
                        case '4': dec += a * doubleUp; break;
                        case '5': dec += a * doubleUp; break;
                        case '6': dec += a * doubleUp; break;
                        case '7': dec += a * doubleUp; break;
                        case '8': dec += a * doubleUp; break;
                        case '9': dec += a * doubleUp; break;
                        case 'A': dec += 10 * doubleUp; break;
                        case 'B': dec += 11 * doubleUp; break;
                        case 'C': dec += 12 * doubleUp; break;
                        case 'D': dec += 13 * doubleUp; break;
                        case 'E': dec += 14 * doubleUp; break;
                        case 'F': dec += 15 * doubleUp; break;
                        default:
                            break;
                    }
                    count++;
                    if (count == 1)
                    {
                        doubleUp = 16;
                    }
                    else if (count > 1)
                    {
                        doubleUp = doubleUp*16;
                    }
                    
                
                
            }
            Console.WriteLine((int)dec);
        }
    }
}
