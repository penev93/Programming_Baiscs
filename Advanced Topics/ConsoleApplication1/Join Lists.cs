using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class JoinLists
    {
        public static List<int> removeDuplicates(List<int> x)
        {
            for (int i = 0; i < x.Count - 1; i++)
            {
                for (int k = i + 1; k < x.Count; k++)
                {
                    if (x[i] == x[k])
                    {
                        x.RemoveAt(i);
                    }
                }
            }
            return x;
        }
        static void Main(string[] args)
        {
            string firstSeq = Console.ReadLine();
            string secSeq = Console.ReadLine();
            List<int> listOne = new List<int>();
            List<int> listTwo = new List<int>();
            int maxLen=0;
            


            string[] firstArr=firstSeq.Split(new char[]{' '});

            string[] secondArr=secSeq.Split(new char[]{' '});

            for (int i = 0; i < firstArr.Length; i++)
            {
                listOne.Add(int.Parse(firstArr[i]));
                
            }
            for (int i = 0; i < secondArr.Length; i++)
            {
                listTwo.Add(int.Parse(secondArr[i]));
            }

            listOne = removeDuplicates(listOne);
            listTwo = removeDuplicates(listTwo);

            List<int> x = listOne.Union(listTwo).ToList();
            x.Sort();
            foreach (var item in x)
            {
                Console.WriteLine(item+" ");
            }
        }
    }
}
