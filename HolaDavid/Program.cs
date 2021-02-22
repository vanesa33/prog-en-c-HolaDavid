using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Ejercicio_Propuesto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOMBRE;
            Console.Write("Ingrese su nombre : "); NOMBRE = Console.ReadLine();
            if (NOMBRE == "David")
            {
                Console.WriteLine();
                Console.WriteLine("HOLA");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("NO TE CONOZCO");
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}