using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Point_in_a_Circle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
           if((x*x)+(y*y)<=(2*2))
           {
               Console.WriteLine("True");
           }
           else
           {
               Console.WriteLine("False");
           }
           
        }
        
    }
    
}

