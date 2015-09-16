using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Expressions_and_Statements
{
    class OddOrEvenInteger
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}
