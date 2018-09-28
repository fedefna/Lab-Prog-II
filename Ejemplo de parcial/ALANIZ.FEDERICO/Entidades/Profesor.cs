using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor:Persona
    {
        //Atributos
        private DateTime fechaIngreso;

        //properties
        public int Antiguedad
        {
            get
            {
                return (DateTime.Now-fechaIngreso).Days;
            }
        }
        //Metodos
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}. Fecha ingreso: {1}.\n", base.ExponerDatos(), this.fechaIngreso);
            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            return true;
        }

        public Profesor(string nombre,string apellido,string documento):this(nombre,apellido,documento,DateTime.Now)
        {

        }

        public Profesor(string nombre, string apellido, string documento,DateTime fechaIngreso):base(nombre,apellido,documento)
        {
            this.fechaIngreso = fechaIngreso;
        }

    }
}
