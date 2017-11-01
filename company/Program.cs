using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company
{
    class Program
    {
        static void Main(string[] args)
        {
            Company C = new Company(8);
            C.add(1, 2);
            C.add(2, 3);
            C.add(2, 4);
            C.add(2, 5);
            C.add(3, 8);
            C.add(3, 7);
            C.add(5, 6);
            C.print();
            C.findChild();
            C.print();
            C.gentostr();
            C.remove(1, 4);
            C.KJ(0);
            C.print();
            //1 8 6
            //1 3 5
            //1 3 4
            //1 1 2
            //1 2 1
            //1 6 5
            //1 5 6
            //2 3
            //1 1 4
            //1 5 6
            Console.ReadKey();
        }
    }
    class Derevo
    {
        public int Value;
        public int Parent;
        public int Height;
        public List<int> child = new List<int>();
        public string childtostr()
        {
            string s = "";
            for (int i = 0; i < child.Count; i++) s = s + "," + child[i].ToString();
            return s;
        }
    }
    internal class Company
    {
        static private int count;
        Derevo[] Sotr = new Derevo[100000];
        public List<int> gen = new List<int>();
        public string gentostr()
        {
            string s = "";
            for (int i = 0; i < gen.Count; i++) s = s + "," + (gen[i] + 1).ToString();
            Console.WriteLine("Geni -" + s);
            return s;
        }
        public Company(int v)
        {
            Company.count = v;
            for (int i = 0; i < count; i++)
            {
                Sotr[i] = new Derevo();
                Sotr[i].Value = i + 1;
                Sotr[i].Parent = 0;
                Sotr[i].Height = 0;
            }
        }

        internal void add(int v1, int v2)
        {
            Sotr[v2 - 1].Parent = v1;
        }

        internal void print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Sotr[i].Value + " " + Sotr[i].Parent + " podchin " + Sotr[i].childtostr() + " h = " + Sotr[i].Height);
            }
        }

        public void findChild()
        {

            for (int i = 0; i < count; i++)
            {

                if ((Sotr[i].Parent) != 0) Sotr[Sotr[i].Parent - 1].child.Add(i + 1); else gen.Add(i);
            }

        }

        public int KJ(int i)
        {
            int r = 0;
            if (Sotr[i].Parent == 0) Sotr[i].Height = 0;
            for (int k = 0; k < Sotr[i].child.Count; i++)
            {
                Sotr[Sotr[i].child[k]].Height = Sotr[i].Height + 1;
                KJ(Sotr[i].child[k]);
            }
            Console.WriteLine(i + " " + Sotr[i].Height);
            return r;
        }

        internal void remove(int v1, int v2)
        {
            Console.WriteLine("Удаление");
            findPut(v1, v2);
        }

        private void findPut(int v1, int v2)
        {
            Console.WriteLine("Поиск пути");

        }
    }
}
