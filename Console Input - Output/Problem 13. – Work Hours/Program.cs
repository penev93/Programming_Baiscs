using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.__Work_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double bikingTime = d * 10 / 100;
            
            d -= bikingTime;

            double hours = d * 12;
            double efficientH = hours * p / 100;
            efficientH=Math.Floor(efficientH);
            double canShe =  efficientH -h;
            Math.Floor(canShe);
            if (canShe < 0)
            {
                Console.WriteLine("No");
                Console.WriteLine(canShe);
            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine(canShe);
            }


        }
    }
}
