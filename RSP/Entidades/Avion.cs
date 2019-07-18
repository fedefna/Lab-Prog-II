using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion
    {
        /// <summary>
        /// Evento
        /// </summary>
        public event ReporteDeEstado ReportarEstado;
        /// <summary>
        /// enum
        /// </summary>
        public enum EstadoVuelo
        {
            Programado,
            Volando,
            Aterrizando
        }

        private int horasVuelo;
        private Thread vuelo;

        public Avion(int horasVuelo)
        {
            this.horasVuelo = horasVuelo;
        }
        /// <summary>
        /// Properties
        /// </summary>
        public EstadoVuelo Estado {
            get
            {
                if (Object.Equals(vuelo, null))
                {
                    return EstadoVuelo.Programado;
                }
                else if (vuelo.IsAlive)
                {
                    return EstadoVuelo.Volando;
                }
                else
                {
                    return EstadoVuelo.Aterrizando;
                }
            }
        }

        public int HorasDeVuelo { get => horasVuelo;}

        EstadoVuelo IAvion.Estado => throw new NotImplementedException();

        /// <summary>
        /// a. Dormirá el hilo durante 1 segundo.
        ///b.Descontará una Hora Restante al vuelo.
        ///c.Invocará el evento Reportar Estado con las horas totales del vuelo y las horas restantes como
        ///argumentos. El método retornará el porcentaje ya completado.
        /// </summary>
        public void Volar()
        {
            int horasRestantes = this.horasVuelo;
            int porcentajeCompletado = 100;
            while (porcentajeCompletado <= 100)
            {
                Thread.Sleep(1000);
                horasRestantes--;
                porcentajeCompletado = this.ReportarEstado(this.horasVuelo, horasRestantes);
            }
        }
        /// <summary>
        /// Despegar declarará e inicilizará el hilo con el método Volar.
        /// </summary>
        public void Despegar()
        {
            vuelo= new Thread(Volar);
            vuelo.Start();
        }
        /// <summary>
        /// Estrellar finalizará el hilo si este está vivo.
        /// </summary>
        public void Estrellar()
        {
            if (vuelo.IsAlive)
            {
                vuelo.Abort();
            }
        }
    }
}
