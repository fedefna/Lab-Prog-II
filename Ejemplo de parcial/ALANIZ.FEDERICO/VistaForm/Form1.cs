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
        private Curso curso;
        bool flag = false;

        public Form1()
        {
            InitializeComponent();
            cbDatAluCurso.DataSource = Enum.GetValues(typeof(Divisiones));
            cbDatAluDivision.DataSource = Enum.GetValues(typeof(Divisiones));
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones> (cbDatAluCurso.SelectedValue.ToString(), out division);
            curso = new Curso((short)nudDatCurAño.Value,division,new Profesor(tbDatCurNombre.Text, tbDatCurApellido.Text, tbDatCurDni.Text));
            flag = true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                rtbDatos.Text = (string)(curso);
            }
            else
            {
                MessageBox.Show("No existe un curso");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Divisiones division;
            Enum.TryParse<Divisiones>(cbDatAluDivision.SelectedValue.ToString(), out division);
            Alumno alumno;
            alumno = new Alumno(txtDatAlumNombre.Text, txbDatAluApellido.Text, txbDatAluLegajo.Text, (short)nudDatAluAño.Value, division);
            curso = curso + alumno;
        }

        private void nudDatAluAño_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
