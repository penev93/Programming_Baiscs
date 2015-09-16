using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Min__Max__Sum_and_Average_of_N_Numbers
{
    class MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                list.Add(digit);
            }

            Console.WriteLine("min = {0}",list.Min());
            Console.WriteLine("max = {0}", list.Max());
            Console.WriteLine("sum = {0}", list.Sum());
            Console.WriteLine("avg = {0:0.00}", list.Average());

        }
    }
}
