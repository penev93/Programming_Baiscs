using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Longest_Word_in_a_Text
{
    class LongesWordinaText
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int temp=0;
            string[] arr=text.Split(new char[]{' ','!',',','?','.',':','-'});

            string b = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length>temp)
                {
                    temp=arr[i].Length;
                    b = arr[i].ToString();
                }
            }
            Console.WriteLine(b);
        }
    }
}
