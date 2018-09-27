using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial : Llamada
    {
        public Provincial(Franja miFranja, Llamada llamada): base (llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino): this(miFranja,new Llamada(duracion, destino, origen))
        {

        }

        protected Franja franjaHoraria;

        public enum Franja
        {
            Franja_1,Franja_2,Franja_3
        }

        private float CalcularCosto()
        {
            float valorLlamada = 0;

            if (this.franjaHoraria == Franja.Franja_1)
            {
                valorLlamada = 0.99f* base.duracion;
            }else if (this.franjaHoraria == Franja.Franja_2)
            {
                valorLlamada = 1.25f * base.duracion;
            }
            else
            {
                valorLlamada = 0.66f * base.duracion;
            }
            return valorLlamada;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}. Costo: {1}. Franja: {2}.", base.Mostrar(),this.CostoLlamada,this.franjaHoraria);
            return sb.ToString();
        }

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
    }
}
