using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Play_with_Int__Double_and_String
{
    class VariableGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            string user = Console.ReadLine();
            
            switch (user)
            {
                case "1":
                    Console.WriteLine("Please enter a int:");
                    int x = int.Parse(Console.ReadLine());
                    x += 1;
                    Console.WriteLine(x);
                    break;
                case "2":
                    Console.WriteLine("Please enter a double:");
                    double y = double.Parse(Console.ReadLine());
                    y += 1;
                    Console.WriteLine(y);
                    break;
                case "3":
                    Console.WriteLine("Please enter a string:");
                    string z = Console.ReadLine();
                    z += '*';
                    Console.WriteLine(z);
                    break;
                
            }
        }
    }
}
