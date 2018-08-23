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
            int num;
            
            num = int.Parse(Console.ReadLine());

            while (num <= 1)
            {
                Console.WriteLine("Ingresar un numero mayor a cero");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("1");

            for (int i=2; i <= num; i++)
            {
                if (esPrimo(i)==true)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }

        static bool esPrimo(int num)
        {
            bool resultado=false;

            for(int i = 1; i < num; i++)
            {
                if (num % i==0)
                {
                    resultado = true;
                }
            }

            return resultado;
        }
    }
}
