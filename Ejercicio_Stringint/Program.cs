using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Stringint
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre, edad;
            Console.WriteLine("Escribe tu nombre ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu edad ");
            edad = Console.ReadLine();
            Console.WriteLine("te llamas " + nombre + "y tienes   " + edad);
            Console.WriteLine("Presiona cualquiera tecla para continuar ");
            Console.ReadKey();
        }
    }
}
