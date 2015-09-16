using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Sum_of_5_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] numbArr = numbers.Split(' ');
            double result = 0;
            for (int i = 0; i < numbArr.Length; i++)
            {
                result += double.Parse(numbArr[i]);
                
            }
            Console.WriteLine(result);
        }
    }
}
