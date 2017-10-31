using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "5 1 1 1 2 2 2 9 9";

            char[] ch = file.ToCharArray().Distinct().ToArray();
            for (int i = 0; i < ch.Length; i++)
                if (ch[i] != ' ')
                    Console.WriteLine("Символ: |{0}| Число повторений: |{1}|", ch[i], file.ToCharArray().Count(x => x == ch[i]));

            Console.ReadKey();
        }
    }
}
