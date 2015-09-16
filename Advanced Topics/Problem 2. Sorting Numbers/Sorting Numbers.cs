using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Sorting_Numbers
{
    class SortingNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> xList = new List<int>();
            int a=0;
            for (int i = 0; i < n; i++)
            {
                a=int.Parse(Console.ReadLine());
                xList.Add(a);
            }
            xList.Sort();
            foreach (var item in xList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
