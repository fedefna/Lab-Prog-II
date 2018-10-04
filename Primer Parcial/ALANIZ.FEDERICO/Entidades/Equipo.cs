using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        #region Fields
        static int cantidadMaximaJugadores=6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;
        #endregion


        #region Properties
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                this.directorTecnico = value;
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
        /// Constructor privado
        /// </summary>
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
            
        }
        /// <summary>
        /// Constructor publico que llama al privado
        /// </summary>
        /// <param name="nombre"></param>
        public Equipo(string nombre):this()
        {
            this.nombre = nombre;
        }
        /// <summary>
        /// Muestra todos los datos del equipo dt y jugadores
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("Nombre: {0}", e.nombre));
            sb.AppendLine(String.Format("Cantidad maxima de jugadores: {0}", cantidadMaximaJugadores));
            sb.AppendLine(String.Format("Director tecnico: "));
            if (e.directorTecnico == null)
            {
                sb.AppendLine(String.Format("Sin DT asignado. "));
            }
            else
            {
                sb.AppendLine(String.Format("{0}", e.directorTecnico.Mostrar()));
            }

            foreach (Jugador a in e.jugadores)
            {
                sb.AppendLine(a.Mostrar());
            }

            return sb.ToString();
        }
        /// <summary>
        /// Devuelve true si el jugador ya esta en el equipo
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;

            foreach (Jugador a in e.jugadores)
            {
                if (a.Dni == j.Dni)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        /// <summary>
        /// Devuelve true si el jugador no esta en el equipo
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        /// <summary>
        /// Agrega al jugador si no esta en el equipo && cant de integrantes no fue superada &&cumpla con aptitud
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count< cantidadMaximaJugadores && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }

            return e;
        }
        /// <summary>
        /// Devuelve true si el equipo tiene dt && tiene 1 jugador de cada posicion && tiene 1 solo arquero &&
        /// cantidad de jugadores igual a cantidadMaximaJugadores
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        static public bool ValidarEquipo(Equipo e)
        {
            bool retorno = false;

            if(e.directorTecnico!=null && cantidadMaximaJugadores == e.jugadores.Count)
            {
                bool arquero = false;
                bool central= false;
                bool defensor = false;
                bool delantero = false;
                foreach (Jugador a in e.jugadores)
                {
                    switch (a.Posicion)
                    {
                        case Posicion.Arquero:
                            arquero = true;
                            break;
                        case Posicion.Central:
                            central = true;
                            break;
                        case Posicion.Defensor:
                            defensor = true;
                            break;
                        case Posicion.Delantero:
                            delantero = true;
                            break;
                        default:
                            break;
                    }
                }
                if (arquero && central && defensor && delantero)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion
    }
}
