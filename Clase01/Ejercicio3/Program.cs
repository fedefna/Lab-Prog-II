using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0;

            while (num <= 1)
            {
                Console.WriteLine("Ingresar un numero mayor a cero: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numeros primos menores a " + num + ":");
            for (int i=1; i <= num; i++)
            {
                if (esPrimo(i)==1)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }

        static int esPrimo(int num)
        {
            int resultado=0;

            int a = 0;

            for (int i = 1; i <=num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a <= 2)
            {
                resultado = 1;
            }

            //Console.WriteLine("Devuelvo resultado: "+resultado);
            return resultado;
        }
    }
}
