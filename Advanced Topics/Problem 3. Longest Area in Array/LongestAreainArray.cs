using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Longest_Area_in_Array
{
    class LongestAreainArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, int> s = new SortedDictionary<string, int>();
            int counter=1;
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                if(s.ContainsKey(str))
                {
                    counter=s[str]+1;
                    s[str]= counter;
                }
                else
                {
                    counter = 1;
                    s.Add(str, counter);
                }
            }
            
            var max = s.OrderByDescending(d => d.Value).First();
            
            Console.WriteLine(max.Value);
            for (int i = 0; i < max.Value; i++)
            {
                Console.WriteLine(max.Key);
            }
        }
    }
}
