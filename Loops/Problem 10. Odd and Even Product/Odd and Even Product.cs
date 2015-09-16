using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Odd_and_Even_Product
{
    class OddandEvenProduct
    {
        static void Main(string[] args)
        {
            string digits = Console.ReadLine();
            string[] digitsArr = digits.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            int odd = 1;
            int even = 1;
            int counter = 1;

            for (int i = 0; i < digitsArr.Length; i++)
            {
                int number = int.Parse(digitsArr[i]);
                if(counter%2==1){
                    odd *= number;
                }
                else
                {
                    even *= number;
                }
                counter++;
            }
            if(odd==even){
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}",odd);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}",odd);
                Console.WriteLine("even_product = {0}",even);
            }
        }
    }
}
