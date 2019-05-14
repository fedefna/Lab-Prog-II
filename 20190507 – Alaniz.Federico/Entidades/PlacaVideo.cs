using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlacaVideo:Periferico
    {
        #region Fields
        private int ramMB;
        #endregion

        #region Methods
        /// <summary>
        /// retornará toda la información de la Placa de Video
        /// </summary>
        /// <returns></returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("PLACA DE VIDEO:  {0}", (String)this));
            sb.AppendLine(String.Format("Memoria: {0}MB.", this.ramMB));

            return sb.ToString();
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="ramMB"></param>
        public PlacaVideo(string marca, string modelo, int ramMB):base(marca,modelo,EConector.PCIExpress)
        {
            this.ramMB = ramMB;
        }
        #endregion
    }
}
