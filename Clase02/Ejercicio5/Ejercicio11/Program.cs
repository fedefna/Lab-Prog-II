using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            for (int i=0; i<10;i++)
            {
                Console.WriteLine("Ingresar un numero entre -100 y 100: ");
                num = int.Parse(Console.ReadLine());
                if (Validacion.Validar(num,-100,100))
                {
                    Console.WriteLine("Esta dentro del rango!");
                }
                else
                {
                    Console.WriteLine("No esta dentro del rango!");
                }
            }

            
            
            Console.ReadKey();
        }
    }
}
