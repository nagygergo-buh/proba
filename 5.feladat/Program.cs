using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int be =0;
            int.TryParse(Console.ReadLine(), out be);
            double kerulet =2*be*Math.PI;
            double terulet =Math.Pow(be,2) *Math.PI;
            //Console.Write("Kör sugara:");
            Console.WriteLine($"Kerület: {kerulet}");
            Console.WriteLine("Terület: ",Math.Round(terulet,4));
            Console.ReadKey();
        }
    }
}
