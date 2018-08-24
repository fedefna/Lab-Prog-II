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
            int num = 1;
            int cantidadPerfectos = 0;

            
            Console.WriteLine("Los 4 primeros numeros perfectos son:");

            while(cantidadPerfectos!=4)
            {
                num++;
                if (esPerfecto(num))
                {
                    Console.WriteLine(num);
                    cantidadPerfectos++;
                }
            }

            Console.ReadKey();
        }

        static bool esPerfecto(int num)
        {
            bool resultado = false;
            int total=0;

            for(int i = 1; i < num; i++)
            {
                if (num % i ==0)
                {
                    total = total + i;
                }
            }

            if (total == num)
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
