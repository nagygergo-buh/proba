using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mennyiség(dl): ");
            int mennyiseg=int.Parse(Console.ReadLine());
            Console.WriteLine($"Hektoliterben: {(double)mennyiseg/1000} hl");
            Console.WriteLine($"Literben: {(double)mennyiseg /10} l");
            Console.WriteLine($"Mililiterben: {(double)mennyiseg *100} ml");



            Console.ReadKey();
        }
    }
}
