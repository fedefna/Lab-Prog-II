using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract public class Persona
    {
        #region Fields
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;
        #endregion

        #region Properties
        public string Apellido {
            get
            {
                return this.apellido;
            }
         }
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Retorna los datos de la persona
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Apellido: {0}. Nombre: {1}. Documento: {2}. Edad: {3}.\n", this.apellido, this.nombre, this.dni, this.edad);
            return sb.ToString();
        }
        /// <summary>
        /// Constructor de persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        public Persona(string nombre,string apellido,int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }
        public abstract bool ValidarAptitud();
        #endregion
    }
}
