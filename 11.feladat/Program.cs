using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a =0,b =0,c =0,F=0,T=0;
            Console.WriteLine("Az a oldal:");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Az b oldal:");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Az c oldal:");
            double.TryParse(Console.ReadLine(), out c);
            F = 2 * a * b + 2 * a * c +2 * b * c;
            T = a * b * c;
            Console.WriteLine("Felszin: {0}",F);
            Console.WriteLine("Térfogat: {0}",T);
            Console.ReadKey();
        }
    }
}
