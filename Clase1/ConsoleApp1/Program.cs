using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, max, min;
            float promedio=0;

            num = int.Parse(Console.ReadLine());
            
            max = num;
            min = num;
            promedio = promedio+num;

            for(int i = 0; i < 4; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (max < num)
                {
                    max = num;
                }
                if (min > num)
                {
                    min = num;
                }
                promedio = promedio + num;
            }
            promedio = promedio / 5;

            Console.WriteLine("Maximo: "+max);
            Console.WriteLine("Minimo: " + min);
            Console.WriteLine("Promedio: " + promedio);
            Console.ReadKey();
        }
    }
}
