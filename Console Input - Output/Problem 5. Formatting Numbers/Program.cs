using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            string result = "";
            string binary = Convert.ToString(a, 2);
            string aStr = "|"+a.ToString("X").PadRight(10);
            string binaryStr = "|" + binary.PadRight(20);
            string bStr =  String.Format("{0:0.00}",b).PadLeft(10);
            string cStr = "|" + String.Format("{0:0.000}", c).PadRight(10) + "|";

            result += aStr+binaryStr+bStr+cStr; 
            Console.WriteLine(result);
        }
    }
}
