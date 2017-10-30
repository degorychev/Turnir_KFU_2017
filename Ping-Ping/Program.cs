using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ping_Ping
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long a = 25, b = 629856, mod = 1000000009, A = 1, B = 1;

            for (int i = 0; i < n; i++)
            {
                A = (A * a) % mod;
                B = (B * b) % mod;
            }
            Console.WriteLine(A + " " + B);
            Console.ReadKey();
        }
    }
}
