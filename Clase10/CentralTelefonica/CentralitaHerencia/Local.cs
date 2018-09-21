using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float valorLlamada = 0;
            valorLlamada = this.costo * base.duracion;
            return valorLlamada;
        }

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : this(new Llamada(duracion, destino, origen), costo)
        {

        }

        public new string Mostrar ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}. Costo: {1}", base.Mostrar(), this.costo);
            return sb.ToString();
        }
        
    }
}
