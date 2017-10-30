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
            DateTime development = DateTime.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            List<string[]> napominaniya = new List<string[]>();

            for (int i = 0; i < n; i++)
                napominaniya.Add(Console.ReadLine().Split(' '));

            for(int i=0; i<n; i++)
            {
                int d = int.Parse(napominaniya[i][0]);
                int h = int.Parse(napominaniya[i][1]);
                int m = int.Parse(napominaniya[i][2]);

                DateTime newdate = development.AddDays(-d).AddHours(-h).AddMinutes(-m);
                Console.WriteLine(newdate.ToString("dd.MM.yyyy HH:mm"));
            }

            Console.ReadKey();
        }
    }
}
