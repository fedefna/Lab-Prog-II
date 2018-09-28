using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno:Persona
    {
        //Atributos de la clase
        private short anio;
        private Divisiones division;

        //Properties de la clase
        public string AnioDivision
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0}°{1}.\n", this.anio, this.division);
                return sb.ToString();
            }
        }

        //Metodos
        public Alumno(string nombre, string apellido, string documento, short anio, Divisiones division):base(nombre,apellido,documento)
        {
            this.anio = anio;
            this.division = division;
        }

        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}. {1}.\n", base.ExponerDatos(),this.AnioDivision);
            return sb.ToString();
        }

        //dará como válido sólo documentos que tengan el siguiente formato XX-XXXXX
        //siendo las X números.Caso contrario retornará false y no se asignará el documento, siguiendo
        //luego con el curso normal de la aplicación.
        protected override bool ValidarDocumentacion(string doc)
        {
            bool resultado = false;

            if (doc.Length == 9 && doc.ElementAt(2) == '-' && doc.ElementAt(7) == '-')
            {
                resultado = true;
                for (int i=0; i < doc.Length; i++)
                {
                    if(i!=2 && i != 7)
                    {
                        if (!char.IsNumber(doc[i]))
                        {
                            resultado = false;
                            break;
                        }
                    }
                }
            }
            return resultado;
        }

    }
}
