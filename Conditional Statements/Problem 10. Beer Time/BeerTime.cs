using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Problem_10.Beer_Time
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine();
            DateTime zo;
            string strAfter = "1:00 PM";
            string strBefore = "2:59 AM";

            DateTime after = DateTime.ParseExact(strAfter, "h:mm tt", CultureInfo.InvariantCulture);
            DateTime before = DateTime.ParseExact(strBefore, "h:mm tt", CultureInfo.InvariantCulture);
            DateTime a1 = DateTime.ParseExact(t, "h:mm tt", CultureInfo.InvariantCulture);
            if (DateTime.TryParse(t, out zo))
            {

                if ((a1.Ticks >= after.Ticks) || (a1.Ticks <= before.Ticks))
               {
                   Console.WriteLine("beer time");
               }

               else
               {
                   Console.WriteLine("non-beer time");
               }
            }
                
            else{
                Console.WriteLine("invalid time");
            }
                
            
           
        }
    }
}
