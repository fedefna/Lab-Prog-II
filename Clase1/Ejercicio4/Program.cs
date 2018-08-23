using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            float promedio = 0;

            num = int.Parse(Console.ReadLine());

            while (num <= 0)
            {
                Console.WriteLine("Ingresar un numero mayor a cero");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El cuadrado: " + Math.Pow(num, 2));
            Console.WriteLine("El cubo: " + Math.Pow(num, 3));

            Console.ReadKey();
        }
    }
}
