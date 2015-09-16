using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string sequence = "";
            for (int i = 2; i <12; i++)
            {
                if(i==11)
                {
                    if (i % 2 == 0)
                    {
                        sequence += i;
                        break;
                    }
                    else
                    {
                        sequence += "-" + i;
                        break;
                    }
                }

                if(i%2==0)
                {
                    
                    sequence += i + ",";
                }
                else
                {
                    sequence += "-" + i + ",";
                }
            }
            Console.WriteLine(sequence);
        }
    }
}
