using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace good_group
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine().Split(' ')[1]);
            string input = Console.ReadLine();
            List<int> segment = input.Split(' ').Select(int.Parse).ToList();
            int Counter = 0;
            while(segment.Count>0)
            {
                List<int> section = segment.ToList();
                while(section.Count>0)
                {
                    Console.Write(string.Join(" ", section));

                    if (SmashList(section) <= k)
                    {
                        Counter++;
                        Console.WriteLine(" +++");
                    }
                    else
                        Console.WriteLine();

                    section.RemoveAt(section.Count - 1);
                }
                segment.RemoveAt(0);
            }

            Console.WriteLine(Counter);
            Console.ReadKey();
        }
        static int SmashList (List<int> inputList)
        {
            int maxcount = 0;
            foreach (int i in inputList.Distinct())
            {
                int count = inputList.Count(x => x == i);
                if (count > maxcount)
                    maxcount = count;
            }
            return maxcount;
        }
    }
}
