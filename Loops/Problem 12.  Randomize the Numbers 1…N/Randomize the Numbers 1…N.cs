using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Randomize_the_Numbers_1_N
{
    class RandomizetheNumbersOnetoN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            var randomNumbers = Enumerable.Range(1, n).OrderBy(x => rnd.Next()).Take(n).ToList();
            foreach (var item in randomNumbers)
            {
                Console.Write("{0} ",item);
            }
        }
    }
}
