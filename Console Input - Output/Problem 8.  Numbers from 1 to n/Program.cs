using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Numbers_from_1_to_n
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers=int.Parse(Console.ReadLine());
            for (int i = 1; i <= numbers; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
