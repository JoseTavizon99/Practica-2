using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Int
{
    class Program
    {
        //hola mundo ctrl+k+c descomentar crtr+k+u
        static void Main(string[] args)
        {
            int numero1 = 5;
            int numero2 = 10;
            int numero3 = 20;
            int suma = numero1 + numero2 + numero3;

            Console.WriteLine("El valor de la suma es:" + suma);
            Console.WriteLine("Presionar cualqueir tecla para continuar");
            Console.ReadKey();
        }
    }
}
