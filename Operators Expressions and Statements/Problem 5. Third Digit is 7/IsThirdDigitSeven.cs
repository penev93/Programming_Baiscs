using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Third_Digit_is_7
{
    class IsThirdDigitSeven
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberStr=number.ToString();
            string x="";

            if(numberStr.Length>=3){
               x= numberStr.Substring(numberStr.Length - 3, 1);
            }
            

            if(x=="7")
            {
                Console.WriteLine(true);
            }
            
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
