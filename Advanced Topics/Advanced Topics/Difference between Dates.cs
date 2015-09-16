using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Advanced_Topics
{
    class DiffBtwDate
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime secDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            double x = 0;
            if(firstDate>secDate)
            {
                x = (firstDate-secDate).TotalDays;
            }
            else
            {
                x = (secDate - firstDate).TotalDays;
            }
            
            Console.WriteLine((int)x);
        }
    }
}
