﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Divide_by_7_and_5
{
    class DivisibleBySevenAndFive
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if(number%5==0 && number%7==0)
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
