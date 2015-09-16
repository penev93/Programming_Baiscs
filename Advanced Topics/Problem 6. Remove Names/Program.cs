using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Remove_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string removeNames = Console.ReadLine();
            string[] namesToRemove = removeNames.Split(new char[] { ' ' });

            for (int i = 0; i < namesToRemove.Length; i++)
            {
                string x = namesToRemove[i];
                int start = names.IndexOf(x);
                if(start==-1)
                {
                    continue;
                }
                int end = x.Length;
                names=names.Remove(start, end);
            }
            Console.WriteLine(names);
        }
    }
}
