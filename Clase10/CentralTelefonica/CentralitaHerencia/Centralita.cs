using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;


        public float GananciasPorLocal
        {
            get
            {
                float resultado = 0;

                return resultado;
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                float resultado = 0;

                return resultado;
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                float resultado = 0;

                return resultado;
            }
        }

        public float Llamadas
        {
            get
            {
                float resultado = 0;

                return resultado;
            }
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipoLlamada)
        {
            float resultado=0;

            return resultado;
        }
    }
}
