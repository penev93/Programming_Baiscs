using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string now = DateTime.Now.ToString("MM'-'dd'-'yyyy hh:mm:ss 'h'");
            Console.WriteLine(now);
        }

    }
}
