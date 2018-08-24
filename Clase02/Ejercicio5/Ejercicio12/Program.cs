using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int total=0;
            char opcion;
            do
            {
                Console.WriteLine("Ingresar un numero a sumar: ");
                num = int.Parse(Console.ReadLine());

                total = total + num;

                Console.WriteLine("La suma es de: " + total);

                Console.WriteLine("Desea continuar? S/N");
                opcion = char.Parse(Console.ReadLine());
                opcion=Char.ToUpper(opcion);
            } while (ValidarRespuesta.ValidaS_N(opcion));
            Console.ReadKey();
        }
    }
}
