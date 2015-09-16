using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.The_Biggest_of_3_Numbers
{
    class TheBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            
            double s = Math.Max(a,b);
            double z = Math.Max(s, c);
            Console.WriteLine(z);
        }
    }
}
