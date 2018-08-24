using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validacion
    {
        static public bool Validar(int valor, int min, int max)
        {
            bool resultado = false;

            if (min < valor &&  valor < max)
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
