using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = "";
            for (int i = 2; i <=1001; i++)
            {
                if (i == 1001)
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

                if (i % 2 == 0)
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
