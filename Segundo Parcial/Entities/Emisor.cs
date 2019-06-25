﻿using System;
using System.Xml.Serialization;

namespace Entities
{
    public delegate void EnviarMensajeDelegate(Emisor e);

    /// <summary>
    /// Product types 
    /// </summary>
    public enum EProducto
    {
        SQLDatabase,
        MonitoringApp,
        AppHosting
    }

    [Serializable]
    public abstract class Emisor
    {
        private EProducto producto;
        private string mensaje;

        [field: NonSerialized]
        public event EnviarMensajeDelegate eventMensaje;

        public EProducto Producto { get => producto; set => producto = value; }

        public string Mensaje { get => mensaje; set => mensaje = value; }

        [XmlIgnore]
        public EnviarMensajeDelegate EventMensaje { get => EventMensaje; set => EventMensaje = value; }   
        

        public abstract void EnviarMensaje();

        public override string ToString()
        {
            return $"{Mensaje} - {Producto}";
        }

        protected Emisor(string mensaje, EProducto producto)
        {
            this.Mensaje = mensaje;
            this.Producto = producto;
        }

        public Emisor()
        {

        }
    }
}
