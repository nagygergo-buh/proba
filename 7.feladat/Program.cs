using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            int.TryParse(Console.ReadLine(), out a);
            int kerulet = 4 * a;
            double terulet = Math.Pow(a,2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("kerület: {0}",kerulet);
            Console.WriteLine("kerület: {0}", terulet);
            Console.ReadKey();
        }
    }
}
