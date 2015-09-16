using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterTenYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Now: ");
            string ageStr = Console.ReadLine();
            int age;
            bool isTrue = int.TryParse(ageStr,out age);
            while (!isTrue)
            {
                
                Console.Write("Please Enter age: ");
                ageStr = Console.ReadLine();
                isTrue = int.TryParse(ageStr, out age);
            }
            int afterTenYears = age + 10;
            Console.WriteLine("After 10 years: "+afterTenYears);
        }
    }
}
