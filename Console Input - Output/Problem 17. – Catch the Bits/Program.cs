using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17.__Catch_the_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            int bytes = int.Parse(Console.ReadLine());
            int steps = int.Parse(Console.ReadLine());

            string zero="";

            int[] bytesArr=new int[bytes];
            string[] bitArr = new string[bytes];
            int bytesLength = 8;
            int result;
            
            for (int i = 0; i < bytes; i++)
            {
                bytesArr[i] = int.Parse(Console.ReadLine());
                bitArr[i] = Convert.ToString(bytesArr[i],2);

                result = bytesLength - bitArr[i].Length;
                for (int j = 0; j < result; j++)
			    {
			        zero+="0";
                    
			    }
                bitArr[i]=bitArr[i].Insert(0, zero);
                zero = "";
            }
            string bitResult = "";
           
            for (int i = 0; i < bytes; i++)
            {
            
                bitResult += bitArr[i];
            }
            int firstStep = 1;
            int count = 0;
            string r = "";
     
            for (int i = 0; i < bitResult.Length; i++)
            {
                if (firstStep + count * steps>bitResult.Length)
                {
                    break;
                }
                
                if(i<1)
                {
                    r += bitResult[1];
                }
                else
                {
                    r += bitResult[firstStep + count * steps];
                }
                count++;
            }

            int size = 0;
            int b = 0;

            if(r.Length<8)
            {
                size = 8 - r.Length;
            }
            else
            {
                b=r.Length/8;
                size = r.Length-(b * 8);
            }
            
            zero = "";
           
            for (int i = 0; i < size; i++)
            {
                zero += "0";
            }
   
           r= r.Insert(r.Length, zero);

           for (int i = 0; i <= r.Length; i++)
           {
               while (r.Length!=0)
               {
                   string final = r.Substring(0, 8);
                   int x = Convert.ToInt32(final, 2);
                   Console.WriteLine(x);
                   r=r.Remove(0, 8);
               }
               
           }
            
        }
    }
}
