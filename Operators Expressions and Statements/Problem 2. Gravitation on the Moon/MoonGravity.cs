using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Gravitation_on_the_Moon
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double weightOnMoon = weight * 17 / 100;
            Console.WriteLine(weightOnMoon);
        }
    }
}
