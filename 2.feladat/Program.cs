using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Első szám: ");
            int szam1=int.Parse(Console.ReadLine());
            Console.Write("Második szám: ");
            int szam2=int.Parse(Console.ReadLine());
            double oszt = szam1 / szam2;
            Console.WriteLine($"A két szám szorzata: {szam1*szam2}");
            Console.WriteLine($"A két szám hányadosa: {Math.Round(oszt,2)}");
            

            Console.ReadKey();
        }
    }
}
