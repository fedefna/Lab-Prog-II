using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        //Atributos de la clase
        private string apellido;
        private string documento;
        private string nombre;

        //properties de la clase
        public string Apellido
        {
            get
            {
                return apellido;
            }
        }

        public string Documento
        {
            get
            {
                return documento;
            }
            set
            {
                if (ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        //Metodos
        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Apellido: {0}. Nombre: {1}. Documento: {2}.\n", this.apellido,this.nombre,this.documento);
            return sb.ToString();
        }

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }

        //Metodo abstracto para sobreescribir
        abstract protected bool ValidarDocumentacion(string doc);

    }
}
