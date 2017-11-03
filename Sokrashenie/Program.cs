using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokrashenie
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n = int.Parse(Console.ReadLine());
            var n = int.Parse("5");
            //string[] input = Console.ReadLine().Split(' ');
            string[] input = "3 2 1 2 1".Split(' ');

            int[] mass = new int[n];
            for (int i = 0; i < n; i++)
                mass[i] = int.Parse(input[i]);


            double min = 1;


            HashSet<int> currentSet = new HashSet<int>();         


            for (var a = 0; a < n; a++)
            {
                int niz = 1;
                for (var b = a; b < n; b++)
                {
                    currentSet.Add(mass[b]);
                    double newRes = (double)currentSet.Count / (niz++);
                    if (newRes < min)
                        min = newRes;
                    //Console.Write(mass[b] + " | ");
                }
                Console.WriteLine(" ДИЧЬ=" + min.ToString("0.000000", CultureInfo.GetCultureInfo("en-US")));
                currentSet.Clear();
            }
            Console.WriteLine(min.ToString("0.000000", CultureInfo.GetCultureInfo("en-US")));
            Console.ReadKey();
        }
    }
}
