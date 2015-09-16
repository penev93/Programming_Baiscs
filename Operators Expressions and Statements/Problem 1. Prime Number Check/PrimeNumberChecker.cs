using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Prime_Number_Check
{
    class PrimeNumberChecker
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isTrue = true;
            if(number<=100)
            {
                if (number == 1)
                {
                    isTrue = false;
                    
                }
                else { 
                    for (int i = 2; i <100 ; i++)
                    {
                        if(number%i==0 && i!=number){
                            isTrue = false;
                            break;
                        
                        }
                    }
                }

            }
            Console.WriteLine(isTrue);
        }
    }
}
