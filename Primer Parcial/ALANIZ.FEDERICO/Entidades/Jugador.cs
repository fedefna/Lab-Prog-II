using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador:Persona
    {
        #region Fields
        private float altura;
        private float peso;
        private Posicion posicion;
        #endregion

        #region Properties
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }
        public float Peso
        {
            get
            {
                return this.peso;
            }
        }
        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Constructor de jugador que llama al constructor de persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="edad"></param>
        /// <param name="dni"></param>
        /// <param name="peso"></param>
        /// <param name="altura"></param>
        /// <param name="posicion"></param>
        public Jugador(string nombre,string apellido, int edad,int dni, float peso, float altura, Posicion posicion):base(nombre,apellido,edad,dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = Posicion;
        }
        /// <summary>
        /// Metodo mostrar sobreescrito
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}. Altura: {1}. Peso: {2}. Posicion: {3}.\n", base.Mostrar(), this.altura,this.peso,this.posicion);
            return sb.ToString();
        }
        /// <summary>
        /// devuelve true si la masa corporal esta entre 18.5y25.
        /// </summary>
        /// <returns></returns>
        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            float imc = this.Peso/this.Altura;
            if (18.5 <= imc && imc <= 25)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Devuelve true si el jugador no supera los 40 años y se encuentra en estado fisico.
        /// </summary>
        /// <returns></returns>
        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if (this.Edad < 40 && this.ValidarEstadoFisico())
            {
                retorno = true;
            }
            return retorno;
        }


        #endregion
    }
}
