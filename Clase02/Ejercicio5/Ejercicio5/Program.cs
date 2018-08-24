using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (num <= 1)
            {
                Console.WriteLine("Ingresar un numero mayor a cero: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El centro numerico es: "+calcularCentro(num));
            Console.ReadKey();
        }

        static int calcularCentro(int num)
        {
            int resultado = -1;
            int suma = 0;

            for(int i = 1; i < num; i++)
            {
                suma = suma + (i-1);
                if (suma==segundoGrupo(num,i))
                {
                    resultado = i;
                    break;
                }
            }
            
            return resultado;
        }

        static int segundoGrupo(int num, int indice)
        {
            int resultado = 0;

            for (int i = indice+1; i <= num; i++)
            {
                resultado = resultado + i;
            }

            return resultado;
        }
    }
}
