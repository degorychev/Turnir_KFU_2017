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
            FindD("1 2 3 4 5 6");
            Console.ReadKey();
        }
        static public bool FindD(string input)
        {
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

                        Console.WriteLine(bstr);

                        bstr = "";
                        h = 0;
                        ii = ii - perDel + 1;
                    }
                }
            } while (perDel > 1);
            return true;
        }
    }
}
