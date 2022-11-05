using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = true;
            while (salir)
            {
                Console.Clear();
                Console.WriteLine("Escriba una cadena de texto o presione el número 0 para salir");
                string cadena = Console.ReadLine();

                if (cadena == "0")
                {
                    return;
                }

                int vocales = 0;

                for (int i = 0; i < cadena.Length; i++)
                {
                    if (cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u' || cadena[i] == 'A' || cadena[i] == 'E' || cadena[i] == 'I' || cadena[i] == 'O' || cadena[i] == 'U')
                    {
                        vocales++;
                    }
                }

                Console.WriteLine("Número de vocales encontradas: " + vocales);
                Console.WriteLine("Presiona cualquier tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}
