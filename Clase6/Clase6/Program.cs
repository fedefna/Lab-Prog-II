using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Console.WriteLine("Decimal a binario: " + Conversor.DecimalBinario(10));
      Console.WriteLine("Binario a decimal: " + Conversor.BinarioDecimal("10100"));
      Console.ReadKey();
    }
  }
}
