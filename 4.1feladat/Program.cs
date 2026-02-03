using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hosszúság(mm): ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nMéter: {szam1 / 1000} m");
            Console.WriteLine($"Deciméter: {(szam1-(szam1/1000)*1000)/100} dm");
            Console.WriteLine($"Centiméter: {szam1 / 10} cm");
            Console.WriteLine($"Miliméter: {szam1 / 10} cm");

            Console.ReadKey();
        }
    }
}
