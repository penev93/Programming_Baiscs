using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class  ExchangeValues
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if(a>b)
            {
                double temp = b;
                b = a;
                a = temp;
            }
            Console.WriteLine("{0} {1}",a,b);
        }
    }
}
