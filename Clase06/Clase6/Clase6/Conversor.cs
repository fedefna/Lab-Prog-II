using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
  class Conversor
  {
    //Convierte un número de decimal a binario.
    public static string DecimalBinario(double numero)
    {
      string retorno = "0";
      while (numero > 0)
      {
        if (numero % 2 == 0)
        {
          retorno = "0" + retorno;
        }
        else
        {
          retorno = "1" + retorno;
        }
        numero = (int)(numero / 2);
      }
      return retorno;
    }

    //Convierte un número binario a decimal.
    public static double BinarioDecimal(string num)
    {
      double retorno = 0;

      char[] array = num.ToCharArray();
      // Invertido pues los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
      Array.Reverse(array);

      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == '1')
        {
          // Usamos la potencia de 2, según la posición
          retorno += (int)Math.Pow(2, i);
        }
      }
      return retorno;
    }
  }
}
