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
            string inputdatetime = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            List<string> napominaniya = new List<string>();
            for (int i=0; i<n; i++)
                napominaniya.Add(Console.ReadLine());

            DateTime development = DateTime.Parse(inputdatetime);

            foreach(string nap in napominaniya)
            {
                string[] str = nap.Split(' ');
                int d = int.Parse(str[0]);
                int h = int.Parse(str[1]);
                int m = int.Parse(str[2]);

                DateTime newdate = development.AddDays(-d).AddHours(-h).AddMinutes(-m);
                Console.WriteLine(newdate.ToShortDateString() + " " + newdate.ToShortTimeString());
            }
            
            //Console.ReadKey();
        }
    }
}
