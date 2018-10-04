using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico:Persona
    {
        #region Fields
        private int añosExperiencia;
        #endregion
        #region Properties
        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Constructor de director tecnico que llama al de persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <param name="añosExperiencia"></param>
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia):base(nombre,apellido,edad,dni)
        {
            this.añosExperiencia = añosExperiencia;
        }
        /// <summary>
        /// Metodo mostrar sobreescrito
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}. Años de Experiencia: {1}.\n", base.Mostrar(), this.añosExperiencia);
            return sb.ToString();
        }
        /// <summary>
        /// Metodo validar aptitud retorna true si  edad es menor a 65 y años de exp >=a 2
        /// </summary>
        /// <returns></returns>
        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if(this.Edad<65 && this.AñosExperiencia >= 2)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
