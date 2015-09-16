using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Sort_3_Numbers
{
    class SortThreeNumbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            string res = "";
            if(a >b && a > c)
            {
                res += a+" ";
            }
            else if(b > a && b > c)
            {
                res += b + " ";
            }
            else if(c > a && c > b)
            {
                res += c + " ";
            }

            if((a > b && a < c )|| (a>c && a<b ))
            {
                res += a + " ";
            }
            else if ((b > a && b < c) || (b > c && b < a))
            {
                res += b + " ";
            }
            else if ((c > b && c < a) || (c > a && c < b))
            {
                res += c + " ";
            }


            if (a < b && a < c)
            {
                res += a + " ";
            }
            else if (b < a && b < c)
            {
                res += b + " ";
            }
            else if (c < a && c < b)
            {
                res += c + " ";
            }

            if(a==b && a==c)
            {
                Console.WriteLine("{0} {1} {2}",a,b,c);
            }else
            {
                Console.WriteLine(res);
            }
            
        }
    }
}
