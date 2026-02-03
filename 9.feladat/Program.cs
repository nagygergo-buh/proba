using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a =0, b =0;
            Console.WriteLine("A oldal:");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("B oldal:");
            double.TryParse(Console.ReadLine(), out b);
            double K =Math.Round(2 * (a + b));
            double T = Math.Round((a + b));
            Console.WriteLine("kerület: {0}\nterulet: {1}", K,T);
            //Console.WriteLine("kerület: ",K + "\nterulet: " +T);

            Console.ReadKey();
        }
    }
}
