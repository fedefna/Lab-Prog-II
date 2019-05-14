using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Teclado:Periferico
    {
        #region enumEDistribucion
        public enum EDistribucion
        {
            Dvorak, QWERTY, QWERTZ, AZERTY
        }
        #endregion

        #region Fields
        private EDistribucion distribucion;
        #endregion

        #region Methods
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="conector"></param>
        public Teclado(string marca, string modelo, EConector conector):base(marca,modelo,conector)
        {
            this.distribucion = EDistribucion.Dvorak;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="conector"></param>
        /// <param name="region"></param>
        public Teclado(string marca, string modelo, EConector conector, EDistribucion region) : base(marca, modelo, conector)
        {
            this.distribucion = region;
        }

        /// <summary>
        /// Retorna true si el teclado pertenece a la distribucion
        /// </summary>
        /// <param name="t"></param>
        /// <param name="distribucion"></param>
        /// <returns></returns>
        public static bool operator ==(Teclado t, EDistribucion distribucion)
        {
            bool retorno = false;

            if (t.distribucion == distribucion)
            {
                retorno = true;
            }

            return retorno;
        }
        /// <summary>
        /// Devuelve true si el teclado no pertenece a la distribucion
        /// </summary>
        /// <param name="t"></param>
        /// <param name="distribucion"></param>
        /// <returns></returns>
        public static bool operator !=(Teclado t, EDistribucion distribucion)
        {
            return !(t == distribucion);
        }
        /// <summary>
        /// retornará toda la información del Teclado
        /// </summary>
        /// <returns></returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("TECLADO:  {0}", (String)this));
            sb.AppendLine(String.Format("Distribución: {0}.", this.distribucion));

            return sb.ToString();
        }
        #endregion
    }
}
