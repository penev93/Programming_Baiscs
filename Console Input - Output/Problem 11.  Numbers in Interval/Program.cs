using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Numbers_in_Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            string result = "";
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0 && end==i)
                {
                    result += i;
                }

                else if(i%5==0)
                {
                    result += i + ", ";
                }
             
            }
            Console.WriteLine(result);
        }
    }
}
