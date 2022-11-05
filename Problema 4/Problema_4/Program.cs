using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de amigos");
            int amigos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de porciones que desea cada uno");
            int porciones = Convert.ToInt32(Console.ReadLine());
            int pasteles = porciones * amigos;
            int total = (pasteles / 4) + 1;
            Console.WriteLine("Se necesitan: " + total + " pasteles");
            Console.ReadLine();
        }
    }
}
