using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d = new int[10];
            Random r = new Random();
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = r.Next(100);
                Console.WriteLine(d[i]);
            }
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < d.Length; j++)
                {
                    if (d[i] > d[j])
                    {
                        int gd = d[i];
                        d[i] = d[j];
                        d[j] = gd;
                    }
                }
            }
            Console.WriteLine("---------------------------");
            foreach (int item in d)
                Console.WriteLine(item);
        }
    }
}
