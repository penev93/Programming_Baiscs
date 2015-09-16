using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Matrix_of_Numbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int counter = 4;
            int start = 1;
            int number = int.Parse(Console.ReadLine());
            int z = number;
            for (int i = 0; i < number; i++){
                for (int j = start; j <= z; j++)
                {
                    Console.Write("{0} ",j);
                }
                counter += 1;
                start += 1;
                z++;
                Console.WriteLine();
            }
        }
    }
}
