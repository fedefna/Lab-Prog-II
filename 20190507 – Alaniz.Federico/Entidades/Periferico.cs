using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    #region Enum
    public enum EConector
    {
        PCIExpress, USB, MiniUSB, MicroUSB, PS2
    }
    #endregion
    abstract public class Periferico
    {
        #region Fields
        private string marca;
        private EConector conector;
        private string modelo;
        #endregion

        #region Metodos

        /// <summary>
        /// El operador explícito retornará toda la información del periférico
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Periferico p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("Marca: {0}", p.marca));
            sb.AppendLine(String.Format("Modelo: {0}", p.modelo));
            sb.AppendLine(String.Format("Contenedor: {0}", p.conector));

            return sb.ToString();
        }
        /// <summary>
        /// ExponerDatos será abstracto
        /// </summary>
        /// <returns></returns>
        public abstract string ExponerDatos();

        /// <summary>
        /// Devuelve true si los perifericos son iguales
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Periferico p1, Periferico p2)
        {
            bool retorno = false;

            if (p1.marca == p2.marca && p1.modelo == p2.modelo)
            {
                retorno = true;
            }

            return retorno;
        }
        /// <summary>
        /// Devuelve true si 2 perifericos son diferentes
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator!=(Periferico p1, Periferico p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="conector"></param>
        public Periferico(string marca, string modelo, EConector conector)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.conector = conector;
        }
        #endregion
    }
}
