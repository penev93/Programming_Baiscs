using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bonus_Score
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            bool isInvalid = false;
            int score = int.Parse(Console.ReadLine());
            if(score>=1 && score<=3)
            {
                score *= 10;
            }
            else if (score >= 4 && score <= 6)
            {
                score *= 100;
            }
            else if (score >= 7 && score <= 9)
            {
                score *= 1000;
            }
            else 
            {
                isInvalid = true;
            }
            
            if(isInvalid==true)
            {
                Console.WriteLine("invalid score");
            }
            else
            {
                Console.WriteLine(score);
            }
        }
    }
}
