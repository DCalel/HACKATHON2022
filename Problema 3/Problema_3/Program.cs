using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "";
            Console.WriteLine("Ingrese un numero factorial con la siguiente estructura 'n!' \n");
            num = Console.ReadLine();
            int l = 0;
            string letra = num.Substring(num.Length - 1);

            
            if (letra == "!")
            {
                letra = num.Substring(0, num.Length - 1);
                l = Convert.ToInt32(letra);
                Console.WriteLine("El resultado del factorial es: " + factorial(Convert.ToInt32(l)));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Al numero factorial le hace falta '!' en su escritura");
                Console.ReadLine();
            }
            Console.ReadKey();
        }

        static int factorial(int n)
        {
            int resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado = resultado * i;
            }
            return resultado;
        }
    }
}
