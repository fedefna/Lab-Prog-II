using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Maquina
    {
        #region Fields
        private int cantidadMaxPerifericos;
        private string nombre;
        private List<Periferico> perifericos;
        #endregion

        #region Properties
        /// <summary>
        ///  validará que la cantidad no sea menor a 1 ni mayor a 4. Si
        ///está fuera de dicho rango, asignará el valor más bajo o más alto según corresponda al atributo; caso
        ///contrario asignará el valor recibido
        /// </summary>
        public int CantidadMaximaPerifericos
        {
            
            get
            {
                return this.cantidadMaxPerifericos;
            }

            set
            {
                if (value < 1)
                {
                    this.cantidadMaxPerifericos = 1;
                }else if (value > 4)
                {
                    this.cantidadMaxPerifericos = 4;
                }
                else
                {
                    this.cantidadMaxPerifericos = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre=value;
            }
        }
        /// <summary>
        /// La propiedad SystemInfo retornará toda la información de la máquina, incluida la de sus periféricos,
        /// según corresponda su tipo(Teclado o PlacaVideo).
        /// </summary>
        public string SystemInfo
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine(String.Format("Nombre: {0}", this.nombre));
                sb.AppendLine(String.Format("Cantidad maxima de perifericos: {0}", this.cantidadMaxPerifericos));
                
                foreach (Periferico p in this.perifericos)
                {
                    sb.AppendLine(p.ExponerDatos());
                }

                return sb.ToString();
            }
        }


        #endregion

        #region Methods
        /// <summary>
        /// Constructor
        /// </summary>
        private Maquina()
        {
            this.perifericos = new List<Periferico>();
            this.cantidadMaxPerifericos = 3;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public Maquina(string nombre) :this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        ///  será verdadero si el elemento ya forma parte de la
        ///  máquina, según la comparación descripta anteriormente.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Maquina m, Periferico p)
        {
            bool retorno = false;

            foreach (Periferico per in m.perifericos)
            {
                if (per == p)
                {
                    retorno = true;
                }
            }

            return retorno;
        }
        /// <summary>
        ///  será verdadero si el elemento no forma parte de la
        ///  máquina, según la comparación descripta anteriormente.
        /// </summary>
        /// <param name="m"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Maquina m, Periferico p)
        {
            return !(m == p);
        }
        /// <summary>
        /// El operador + agregará un nuevo periférico, siempre y cuando este no se encuentre con anterioridad
        ///  en la lista ni se haya superado la cantidad máquina permitida.
        ///  i.Si lo logra, retornará: "Periferico conectado!".
        ///  ii.Caso contrario retornará: "No se puede conectar el dispositivo.".
        /// </summary>
        /// <param name="m"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static String operator +(Maquina m, Periferico p)
        {
            string retorno = "No se puede conectar el dispositivo.";
            if (m != p && m.perifericos.Count < m.cantidadMaxPerifericos)
            {
                m.perifericos.Add(p);
                retorno = "Periferico conectado!";
            }

            return retorno;
        }
        /// <summary>
        /// El operador – quitará el periférico indicado de la lista.
        /// i.Si lo logra, retornará: "Periferico desconectado!".
        /// ii.Caso contrario retornará: "No se puede desconectar el dispositivo.".
        /// </summary>
        /// <param name="m"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static String operator -(Maquina m, Periferico p)
        {
            string retorno = "No se puede desconectar el dispositivo.";
            if (m == p)
            {
                foreach (Periferico per in m.perifericos)
                {
                    if (per == p)
                    {
                        m.perifericos.Remove(per);
                        retorno = "Periferico desconectado!";
                        break;
                    }
                }
            }

            return retorno;
        }
        #endregion
    }
}
