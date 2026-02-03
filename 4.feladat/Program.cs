using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hosszúság(mm): ");
            int szam1=int.Parse(Console.ReadLine());
            Console.WriteLine($"Méterben: {(double)szam1/1000} m");
            Console.WriteLine($"Deciméterben: {(double)szam1/100} dm");
            Console.WriteLine($"Centiméterben: {(double)szam1/10} cm");

            Console.ReadKey();
        }
    }
}
