using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Entities;
using Persistencia;

namespace SegundoParcial
{
    public partial class FrmSender : Form
    {
        private readonly List<Thread> hilos;

        public FrmSender()
        {
            InitializeComponent();
            hilos = new List<Thread>();

            this.cmbProducto.Items.AddRange(Enum.GetNames(typeof(EProducto)));
        }

        /// <summary>
        /// El botón Enviar Email debe crear un EmisorDeEmails, agregar al eventMensaje el 
        /// manejador “EmailDB.Guardar” y “MostrarMensaje” y ejecutar el método EnviarMensaje 
        /// (del objeto EmisorDeEmails) en un hilo nuevo. (Este método invocará al evento.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSendEmail_Click(object sender, EventArgs e)
        {
            EmisorDeEmails emisorDeEmails = new EmisorDeEmails(this.richMensaje.Text, (EProducto)Enum.Parse(typeof(EProducto),this.cmbProducto.SelectedItem.ToString()), this.txtEmail.Text);
            emisorDeEmails.eventMensaje += this.MostrarMensaje;
            emisorDeEmails.eventMensaje += new EmailDB().Guardar;

            Thread thread = new Thread(emisorDeEmails.EnviarMensaje);
            thread.Start();

            this.hilos.Add(thread);
        }

        /// <summary>
        /// Email info utilizarán las clase EmailDb para traer la 
        /// información de la base de datos y el archivo de texto dependiendo el caso.	
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMailInfo_Click(object sender, EventArgs e)
        {
            EmailDB emailDb = new EmailDB();
            List<EmisorDeEmails> emisores = emailDb.Leer();
            foreach (EmisorDeEmails item in emisores)
            {
                this.richOutPut.Text = item.Mostrar();
            }
        }

        /// <summary>
        /// El botón Enviar Whatsapp hace lo mismo con el objeto EmisorDeWhatsapp per 
        /// agrega al event eventMensaje el manejador “WhatsappTexto.Guardar” y “MostrarMensaje” 
        /// y ejecutar el método EnviarMensaje (del objeto EmisorDeEmails) en un hilo nuevo. 
        /// (Este método invocará al evento.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSendWhat_Click(object sender, EventArgs e)
        {
            EmisorDeWhatsapp emisorDeWhatsapp = new EmisorDeWhatsapp(this.richMensaje.Text, (EProducto)Enum.Parse(typeof(EProducto), this.cmbProducto.SelectedItem.ToString()));
            emisorDeWhatsapp.eventMensaje += this.MostrarMensaje;
            emisorDeWhatsapp.eventMensaje += new WhatsappTexto().Guardar;

            Thread thread = new Thread(emisorDeWhatsapp.EnviarMensaje);
            thread.Start();

            this.hilos.Add(thread);
        }

        /// <summary>
        /// Whatsapp info utilizarán las clase WhatsappTexto para traer la información de la 
        /// base de datos y el archivo de texto dependiendo el caso.	
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWhatInfo_Click(object sender, EventArgs e)
        {
            WhatsappTexto texto = new WhatsappTexto();
            this.richOutPut.Text = texto.Leer();
        }

        /// <summary>
        /// recibe un objeto del tipo Emisor y muestra en un MessageBox el siguiente mensaje: 
        /// $"{mensaje.GetType().Name} - Se envió mensaje del producto: {mensaje.Producto}”
        /// </summary>
        /// <param name="emisor"></param>
        private void MostrarMensaje(Emisor emisor)
        {
            MessageBox.Show($"{emisor.GetType().Name} - Se envio mensaje del producto {emisor.Producto}");
        }

        /// <summary>
        /// Cuando se cierra la aplicación abortar todos los hilos. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSender_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var item in this.hilos)
            {
                item.Abort();
            }
        }
    }
}
