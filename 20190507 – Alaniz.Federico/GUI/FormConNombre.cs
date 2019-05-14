using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormConNombre : Form
    {
        private Maquina m;

        public FormConNombre()
        {
            InitializeComponent();
            this.m = new Maquina("LAB01PC03");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PlacaVideo placa = new PlacaVideo(txtMarca.Text, txtModelo.Text, (int)nudMemoria.Value);

            MessageBox.Show(m + placa);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            PlacaVideo placa = new PlacaVideo(txtMarca.Text, txtModelo.Text, (int)nudMemoria.Value);
            MessageBox.Show(m - placa);
        }

        private void btnSystemInfo_Click(object sender, EventArgs e)
        {
            rtxtSystemInfo.Text = m.SystemInfo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
