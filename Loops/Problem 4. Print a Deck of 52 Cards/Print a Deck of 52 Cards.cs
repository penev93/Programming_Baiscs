using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Print_a_Deck_of_52_Cards
{
    class PrintaDeck
    {
        static void Main(string[] args)
        {

            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            char[] suits = { '\x05', '\x04', '\x03', '\x06' };



            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    Console.Write("{0}{1}",cards[i],suits[j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
