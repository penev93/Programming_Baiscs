using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] arr = new char[] { 'a', 'b', 'c' ,'d','e','f'};
            int temp;
            bool isTrue=false;
            string[] inputSplit = input.Split(new char[]{' '});
            int x = int.Parse(inputSplit[0]);
            int y = int.Parse(inputSplit[1]);
            int z = x * y;
            string str = "";
            int zoo = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Random rnd = new Random();
                        
                        
                        if(isTrue)
                        {
                            temp = rnd.Next(0, 2);
                            str += arr[temp];
                            isTrue = false;
                        }
                        else
                        {
                            isTrue = true;
                            zoo = rnd.Next(3, 5);
                            str += arr[zoo];
                        }
                            
                    }
                    str += " ";    
                    }
                    
                    Console.WriteLine(str);
                    str = "";
                }
                
            }
        }
    }
