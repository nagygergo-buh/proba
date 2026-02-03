using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.feladat
{
    internal class Program
    {
        //𝑇 = Math.PI * r * m
        //𝐹 = 2 * Math.PI * r * (r + m)
        static void Main(string[] args)
        {
            double r = 0, m = 0, T = 0, F = 0;

            T = Math.PI * r * m;
            F = 2 * Math.PI * r * (r + m);

            Console.ReadKey();
        }
    }
}
