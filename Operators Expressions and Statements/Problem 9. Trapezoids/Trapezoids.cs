using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());            
            double h = double.Parse(Console.ReadLine());
            double area=(((a+b)/2)*h);
            Console.WriteLine(area);
        }
    }
}
