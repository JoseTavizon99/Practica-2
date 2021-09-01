using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int c = 7;
            int b = 10;
            int suma = a + b + c;

            Console.WriteLine("El perimetro del triangulo  es:" + suma);
            Console.WriteLine("Presionar cualqueir tecla para continuar");
            Console.ReadKey();

        }
    }
}
