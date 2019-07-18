using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Controles
{
    public partial class Vuelo : UserControl
    {
        private Avion avion;

        /// <summary>
        /// En su constructor declarar el Avión y asociar el evento con Mover Avión.
        /// </summary>
        /// <param name="horasVuelo"></param>
        public Vuelo(int horasVuelo)
        {
            InitializeComponent();
            avion = new Avion(horasVuelo);
            avion.ReportarEstado += MoverAvion;
        }

        /// <summary>
        /// Despegar hará visible el picAvion e invocará al Despegar de avión.
        /// </summary>
        public void Despegar()
        {
            this.picAvion.Enabled = true;
            avion.Despegar();
        }

        /// <summary>
        /// Completar código de MoverAvion (ayuda: sólo agregar código al IF, el ELSE está completo).
        /// </summary>
        /// <param name="horasTotales"></param>
        /// <param name="horasRestantes"></param>
        /// <returns></returns>
        public int MoverAvion(int horasTotales, int horasRestantes)
        {
            if (this.picAvion.InvokeRequired)
            {
                ReporteDeEstado reporte = new ReporteDeEstado(MoverAvion);
                this.Invoke(reporte, new object[] { horasTotales, horasRestantes });
                return 0;
            }
            else
            {
                int porcentajeCompletado = 100 - (horasRestantes * 100) / horasTotales;
                // 664 es 100% entonces X es el porcentajeCompletado
                int ejeX = (664 * porcentajeCompletado) / 100;
                if (ejeX > 664)
                    ejeX = 664;

                this.picAvion.Location = new Point(ejeX + 58, this.picAvion.Location.Y);

                return porcentajeCompletado;
            }
        }
    }
}
