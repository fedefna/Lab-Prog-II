using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidarRespuesta
    {
        static public bool ValidaS_N(char c)
        {
            bool resultado = false;

            if (c=='S')
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
