using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Circle_Perimeter_and_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI*Math.Pow(r,2) ;
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("Perimeter : {0:0.00}",perimeter);
            Console.WriteLine("Area : {0:0.00}", area);
        }
    }
}
