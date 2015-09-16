using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Four_Digit_Number
{
    class FourDigitNumber
    {
        public static string ReversStr(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return arr.ToString();
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter=0;
            int x = 0;
            List<int> intArr = new List<int>();
            while(number>0){
                x = number % 10;
                number /= 10;
                intArr.Add(x);
                counter++;
                //sum and reverse
            }

            int sum=0;
            int c = intArr.Count;

            
            for (int i = 0; i < intArr.Count; i++)
            {
                sum += intArr[i];
            }

            Console.WriteLine();
           
            Console.WriteLine(sum);

            foreach (var item in intArr)
            {
                Console.Write(item);

            }
            Console.WriteLine();
            intArr.Reverse();
            string a1 = intArr[intArr.Count - 1].ToString(); ;
            for (int i = 0; i < intArr.Count - 1; i++)
            {
                a1 += intArr[i];
            }
            Console.WriteLine(a1);

            
            int second=intArr[1];
            int third = intArr[2];
            intArr[2] = second;
            intArr[1] = third;
            foreach (var item in intArr)
            {
                Console.Write(item);
            }
            
            Console.WriteLine();
           
           
            
            
        }
    }
}
