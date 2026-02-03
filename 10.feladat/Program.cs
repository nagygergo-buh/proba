using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0,F=0,T=0;
            Console.Write("Kocka hossza:");
            double.TryParse(Console.ReadLine(), out a);
            F = 6 * a*2;
            T = Math.Pow(a,3);
            Console.WriteLine("felület: {0}",F);
            Console.Write("Felszin: {0}",T);

            Console.ReadKey();
        }
    }
}
