using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Első szám: ");
            int szam1= Convert.ToInt32(Console.ReadLine());
            Console.Write("Második szám: ");
            int szam2= int.Parse(Console.ReadLine());

            Console.WriteLine($"Összeg: {szam1+szam2}");
            Console.WriteLine($"Külombség: {szam1-szam2}");



            Console.ReadKey();
        }
    }
}
