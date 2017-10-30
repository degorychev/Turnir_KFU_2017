using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napominanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = Console.ReadLine().Split(' ', ':', '.');
            DateTime development = new DateTime(int.Parse(str1[2]), int.Parse(str1[1]), int.Parse(str1[0]), int.Parse(str1[3]), int.Parse(str1[4]), 0);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');

                int d = int.Parse(str[0]);
                int h = int.Parse(str[1]);
                int m = int.Parse(str[2]);

                DateTime newdate = development.AddDays(-d).AddHours(-h).AddMinutes(-m);
                Console.WriteLine(newdate.ToString("dd.MM.yyyy HH:mm"));
            }
            Console.ReadKey();
        }
    }
}