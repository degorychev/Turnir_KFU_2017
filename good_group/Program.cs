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
            string par = "9 2";
            int k = int.Parse(par.Split(' ')[1]);
            string input = "5 1 1 1 2 2 2 9 9";

            int count = 0;
            string[] ms = input.Split(' ');
            int SubStringCount = ms.Count();
            String bstr = "";
            int perDel = ms.Length + 1;
            do
            {
                perDel--;
                int h = 0;
                bstr = "";

                int j = 0;
                for (int ii = 0; ii < SubStringCount; ii++)
                {
                    h++;
                    bstr += ms[ii] + " ";
                    if (h == perDel)
                    {
                        bstr = bstr.Trim();
                        ++j;
                        if (iftrue(bstr, k))
                            count++;
                        //Console.WriteLine(bstr);

                        bstr = "";
                        h = 0;
                        ii = ii - perDel + 1;
                    }
                }
            } while (perDel > 1);
            Console.WriteLine(count);
            Console.ReadKey();
        }

        static bool iftrue(string input, int k)
        {
            List<int> workint = input.Split(' ').Select(int.Parse).ToList();
            workint.Sort();
            Console.WriteLine();
            foreach (int i in workint)
                Console.Write(i + " ");

            int count = 0;
            int memory = 0;
            foreach (int i in workint)
            {
                if (i == memory)
                    count++;
                else
                    count = 0;

                if (count == k)
                    return false;
                memory = i;
            }
            Console.Write("+++");
            return true;
        }
    }
}
