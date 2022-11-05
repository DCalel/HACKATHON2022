using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = true;
            while (salir)
            {
                string operacion;
                string baseNumerica;

                Console.Clear();

                Console.WriteLine("Eliga la operacion: (1)Sumar o (2)Restas (0)Salir y presiona la tecla ENTER");
                operacion = Console.ReadLine();

                if (operacion == "0")
                {
                    return;
                }

                Console.WriteLine("Eliga la base seleccionando un número: (1)Decimal, (2)Binaria o (3)Hexadecimal o (0)Salir");
                baseNumerica = Console.ReadLine();

                if (baseNumerica == "0")
                {
                    return;
                }

                if (Base(baseNumerica) == "10")
                {
                    Operacion(operacion, "10");
                }
                else if (Base(baseNumerica) == "2")
                {
                    Operacion(operacion, "2");
                }
                else if (Base(baseNumerica) == "16")
                {
                    Operacion(operacion, "16");
                }

            }
        }

        public static void Operacion(string operacion, string baseNumerica)
        {
            string num1;
            string num2;

            if (operacion == "1")
            {
                Console.WriteLine("Escriba 2 números para sumar");
                Console.Write("Número 1 : ");
                num1 = Console.ReadLine();

                Console.Write("Número 2 : ");
                num2 = Console.ReadLine();
                
                Console.WriteLine(Sumar(num1, num2, baseNumerica).ToString());
                Console.WriteLine("Presiona cualquier tecla para continuar");
                Console.ReadKey();
            }
            else if (operacion == "2")
            {
                Console.WriteLine("Escriba 2 números para restar");
                Console.Write("Número 1 : ");
                num1 = Console.ReadLine();

                Console.Write("Número 2 : ");
                num2 = Console.ReadLine();

                Console.WriteLine(Restar(num1, num2, baseNumerica).ToString());
                Console.WriteLine("Presiona cualquier tecla para continuar");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Opcion invalida");
            }
        }

        public static string Base(string baseNumerica)
        {
            string resultado = "0";

            if (baseNumerica == "1")
            {
                resultado = "10";
            }
            else if (baseNumerica == "2")
            {
                resultado = "2";
            }
            else if (baseNumerica == "3")
            {
                resultado = "16";
            }
            return resultado;
        }

        public static int Sumar(string num1, string num2, string baseNumerica)
        {
            if (Base(baseNumerica) == "10")
            {             
                if (EsDecimal(num1) == false || EsDecimal(num2) == false)
                {
                    Console.WriteLine("Número invalido");
                    return -1;
                }

            }
            else if (Base(baseNumerica) == "2")
            {
                if (EsBinario(num1) == false || EsBinario(num2) == false)
                {
                    Console.WriteLine("Número invalido");
                    return -1;
                }
            }
            else if (Base(baseNumerica) == "16")
            {
                if (EsHexadecimal(num1) == false || EsHexadecimal(num2) == false)
                {
                    Console.WriteLine("Número invalido");
                    return -1;
                }
            }

            int Num1Decimal = Convert.ToInt32(num1, Convert.ToInt32(baseNumerica));
            int num2Decimal = Convert.ToInt32(num2, Convert.ToInt32(baseNumerica));

            return Num1Decimal + num2Decimal;
        }

        public static int Restar(string num1, string num2, string baseNumerica)
        {
            if (Base(baseNumerica) == "10")
            {
                if (EsDecimal(num1) == false || EsDecimal(num2) == false)
                {
                    Console.WriteLine("Número invalido");
                    return -1;
                }

            }
            else if (Base(baseNumerica) == "2")
            {
                if (EsBinario(num1) == false || EsBinario(num2) == false)
                {
                    Console.WriteLine("Número invalido");
                    return -1;
                }
            }
            else if (Base(baseNumerica) == "16")
            {
                if (EsHexadecimal(num1) == false || EsHexadecimal(num2) == false)
                {
                    Console.WriteLine("Número invalido");
                    return -1;
                }
            }

            int Num1Decimal = Convert.ToInt32(num1, Convert.ToInt32(baseNumerica));
            int num2Decimal = Convert.ToInt32(num2, Convert.ToInt32(baseNumerica));

            return Num1Decimal - num2Decimal;
        }

        public static bool EsDecimal(string num1)
        {
            for (int i = 0; i < num1.Length; i++)
            {
                if (!(num1[i] == '0' || num1[i] == '1' || num1[i] == '2' || num1[i] == '3' || num1[i] == '4' || num1[i] == '5' || num1[i] == '6' || num1[i] == '7' || num1[i] == '8' || num1[i] == '9'))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool EsBinario(string num1)
        {
            for (int i = 0; i < num1.Length; i++)
            {
                if (!(num1[i] == '0' || num1[i] == '1'))
                {
                    return false;
                }
            }
            return true;
        }


        public static bool EsHexadecimal(string num1)
        {
            for (int i = 0; i < num1.Length; i++)
            {
                if (!(num1[i] == '0' || num1[i] == '1' || num1[i] == '2' || num1[i] == '3' || num1[i] == '4' || num1[i] == '5' || num1[i] == '6' || num1[i] == '7' || num1[i] == '8' || num1[i] == '9' || num1[i] == 'A' || num1[i] == 'B' || num1[i] == 'C' || num1[i] == 'D' || num1[i] == 'F'))
                {
                    return false;
                }
            }
            return true;
        }


    }
}
