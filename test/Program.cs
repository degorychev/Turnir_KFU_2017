using System;
using System.Collections.Generic;

namespace zzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int m = int.Parse(Console.ReadLine());
            Queue<int> que = new Queue<int>();
            for (int i=0; i<m; i++)
                que.Enqueue(int.Parse(Console.ReadLine()));
            int len = input.Length;
            while (que.Count>0)
                Console.WriteLine(beauty(que.Dequeue(), len));

            Console.ReadKey();
        }
        static int beauty(int v, int length)
        {
            int sum = 0;
            int buf = 1;
            for (int i = 2; i <= (length - v + 1); i++)
            {
                sum += buf;
                buf += i;
            }
            return sum;
        }
    }
}