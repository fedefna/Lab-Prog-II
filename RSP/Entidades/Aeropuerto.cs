using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aeropuerto<T> where T : IAvion
    {
        private List<T> vuelos;

        public Aeropuerto()
        {
            vuelos = new List<T>();
        }

        public void FinalizarVuelos()
        {
            foreach(IAvion item in vuelos)
            {
                item.Estrellar();
            }
        }

        public static explicit operator String(Aeropuerto <T> a)
        {
            int result=0;
            foreach(IAvion item in a.vuelos)
            {
                if (item.Estado == Avion.EstadoVuelo.Volando)
                {
                    result++;
                }
            }
            return "El aeropuerto cuenta con "+result+" vuelos en estado Volando";
        }
        /// <summary>
        /// El operator + agregará un vuelo a la lista y retornará a.vuelos.Count * 50 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="vuelo"></param>
        /// <returns></returns>
        public static int operator +(Aeropuerto<T> a, T vuelo)
        {
            a.vuelos.Add(vuelo);
            return (a.vuelos.Count * 50);
        }

    }
}
