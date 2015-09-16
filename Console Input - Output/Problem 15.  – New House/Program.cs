using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.__New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double temp = n / 2;
            double a =Math.Floor(temp);
            int b = (int)a;
            string line = "";
            int z=b;
            int z1=b;
            for (int i = 0; i < temp; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(j==b)
                    {
                        line += '*';
                    }
                    else if(j>=z1 && j<=z)
                    {
                        line += '*';
                    }
                    else
                    {
                        line += '-';
                    }
                }
                Console.WriteLine(line);
                line = "";
                z1-=1;
                z+=1;
            }
            string floor = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(j==0 || j==n-1){
                        floor += "|";
                    }
                    else
                    {
                        floor += "*";
                    }
                }
                Console.WriteLine(floor);
                floor = "";
            }
        }
    }
}
