using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{

    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                float resultado = this.duracion;
                return resultado;
            }
        }

        public string NroDestino
        {
            get
            {
                string resultado=this.nroDestino;
                return resultado;
            }
        }

        public string NroOrigen
        {
            get
            {
                string resultado = this.nroOrigen;
                return resultado;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder bl = new StringBuilder();
            bl.AppendFormat("Duracion: {0}. Numero Destino: {1}. Numero Origen: {2}", this.duracion,this.nroDestino,this.nroOrigen);
            string resultado = bl.ToString();
            return resultado;
        }

        //Devuelve 1 si la primer llamada tiene mayor duracion, sino 0.
        public int OrdenarPorDuracion (Llamada llamada1, Llamada llamada2)
        {
            int resultado=0;
            if (llamada1.duracion > llamada2.duracion)
                resultado = 1;
            return resultado;
        }

        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }

    }
}
