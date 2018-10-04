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

namespace VistaForm
{
    public partial class Form1 : Form
    {
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text, (int)numericUpDownEdad.Value, (int)numericUpDownDni.Value, (int)numericUpDownExperiencia.Value);
            MessageBox.Show("Se ha creado el DT!");
            flag = true;
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (dt.ValidarAptitud())
                {
                    MessageBox.Show("El DT es apto!");
                }
                else
                {
                    MessageBox.Show("El DT no es apto");
                }
            }
            else
            {
                MessageBox.Show("Aun no se ha creado el DT del formulario!");
            }
        }
    }
}
