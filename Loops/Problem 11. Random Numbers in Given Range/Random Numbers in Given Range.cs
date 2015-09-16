using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Random_Numbers_in_Given_Range
{
    class RandomNumbersinGivenRange
    {
        static void Main(string[] args)
        {
            Random rnd=new Random();
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int x = rnd.Next(min, max);
                Console.WriteLine("{0} ",x);
            }

        }
    }
}
