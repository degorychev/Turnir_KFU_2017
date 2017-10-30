using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokrashenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            List<int> mass = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            mass.Sort();
            double temp = 0, max = 0;
            max = mass[0];
            for (int i = 1; i < mass.Count; i++)
            {
                if (mass[i - 1] == mass[i])
                    max++;
                else if (temp < max)
                {
                    temp = max;
                    max = 0;
                }
                else
                    max = 0;
            }
            temp = 1 / temp;
            string str = String.Format("{0:0.0000}", temp).ToString().Replace(',', '.');
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
