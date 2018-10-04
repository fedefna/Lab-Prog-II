namespace VistaForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDatosCurso = new System.Windows.Forms.GroupBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.nudDatCurAño = new System.Windows.Forms.NumericUpDown();
            this.cbDatAluCurso = new System.Windows.Forms.ComboBox();
            this.tbDatCurNombre = new System.Windows.Forms.TextBox();
            this.tbDatCurApellido = new System.Windows.Forms.TextBox();
            this.tbDatCurDni = new System.Windows.Forms.TextBox();
            this.dtpDatCurIngreso = new System.Windows.Forms.DateTimePicker();
            this.grbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.txbDatAluApellido = new System.Windows.Forms.TextBox();
            this.txtDatAlumNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDatAluDivision = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDatAluLegajo = new System.Windows.Forms.TextBox();
            this.nudDatAluAño = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.gbDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDatCurAño)).BeginInit();
            this.grbDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDatAluAño)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosCurso
            // 
            this.gbDatosCurso.Controls.Add(this.dtpDatCurIngreso);
            this.gbDatosCurso.Controls.Add(this.tbDatCurDni);
            this.gbDatosCurso.Controls.Add(this.tbDatCurApellido);
            this.gbDatosCurso.Controls.Add(this.tbDatCurNombre);
            this.gbDatosCurso.Controls.Add(this.cbDatAluCurso);
            this.gbDatosCurso.Controls.Add(this.nudDatCurAño);
            this.gbDatosCurso.Controls.Add(this.btnMostrar);
            this.gbDatosCurso.Controls.Add(this.btnCrearCurso);
            this.gbDatosCurso.Controls.Add(this.lblIngreso);
            this.gbDatosCurso.Controls.Add(this.lblDni);
            this.gbDatosCurso.Controls.Add(this.lblApellido);
            this.gbDatosCurso.Controls.Add(this.lblNombre);
            this.gbDatosCurso.Controls.Add(this.lblDivision);
            this.gbDatosCurso.Controls.Add(this.lblAño);
            this.gbDatosCurso.Location = new System.Drawing.Point(12, 12);
            this.gbDatosCurso.Name = "gbDatosCurso";
            this.gbDatosCurso.Size = new System.Drawing.Size(328, 255);
            this.gbDatosCurso.TabIndex = 0;
            this.gbDatosCurso.TabStop = false;
            this.gbDatosCurso.Text = "Datos Curso";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(7, 20);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 0;
            this.lblAño.Text = "Año";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(7, 44);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 1;
            this.lblDivision.Text = "División";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(7, 100);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(7, 127);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(10, 153);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(42, 13);
            this.lblIngreso.TabIndex = 5;
            this.lblIngreso.Text = "Ingreso";
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Location = new System.Drawing.Point(10, 191);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(145, 58);
            this.btnCrearCurso.TabIndex = 6;
            this.btnCrearCurso.Text = "Crear Curso";
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.btnCrearCurso_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(162, 191);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(160, 58);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // nudDatCurAño
            // 
            this.nudDatCurAño.Location = new System.Drawing.Point(60, 20);
            this.nudDatCurAño.Name = "nudDatCurAño";
            this.nudDatCurAño.Size = new System.Drawing.Size(120, 20);
            this.nudDatCurAño.TabIndex = 8;
            // 
            // cbDatAluCurso
            // 
            this.cbDatAluCurso.FormattingEnabled = true;
            this.cbDatAluCurso.Location = new System.Drawing.Point(60, 47);
            this.cbDatAluCurso.Name = "cbDatAluCurso";
            this.cbDatAluCurso.Size = new System.Drawing.Size(121, 21);
            this.cbDatAluCurso.TabIndex = 9;
            // 
            // tbDatCurNombre
            // 
            this.tbDatCurNombre.Location = new System.Drawing.Point(60, 72);
            this.tbDatCurNombre.Name = "tbDatCurNombre";
            this.tbDatCurNombre.Size = new System.Drawing.Size(262, 20);
            this.tbDatCurNombre.TabIndex = 10;
            // 
            // tbDatCurApellido
            // 
            this.tbDatCurApellido.Location = new System.Drawing.Point(60, 100);
            this.tbDatCurApellido.Name = "tbDatCurApellido";
            this.tbDatCurApellido.Size = new System.Drawing.Size(262, 20);
            this.tbDatCurApellido.TabIndex = 11;
            // 
            // tbDatCurDni
            // 
            this.tbDatCurDni.Location = new System.Drawing.Point(60, 127);
            this.tbDatCurDni.Name = "tbDatCurDni";
            this.tbDatCurDni.Size = new System.Drawing.Size(262, 20);
            this.tbDatCurDni.TabIndex = 12;
            // 
            // dtpDatCurIngreso
            // 
            this.dtpDatCurIngreso.Location = new System.Drawing.Point(59, 153);
            this.dtpDatCurIngreso.Name = "dtpDatCurIngreso";
            this.dtpDatCurIngreso.Size = new System.Drawing.Size(263, 20);
            this.dtpDatCurIngreso.TabIndex = 13;
            // 
            // grbDatosAlumno
            // 
            this.grbDatosAlumno.Controls.Add(this.btnAgregar);
            this.grbDatosAlumno.Controls.Add(this.nudDatAluAño);
            this.grbDatosAlumno.Controls.Add(this.txbDatAluLegajo);
            this.grbDatosAlumno.Controls.Add(this.label5);
            this.grbDatosAlumno.Controls.Add(this.cbDatAluDivision);
            this.grbDatosAlumno.Controls.Add(this.label4);
            this.grbDatosAlumno.Controls.Add(this.txbDatAluApellido);
            this.grbDatosAlumno.Controls.Add(this.txtDatAlumNombre);
            this.grbDatosAlumno.Controls.Add(this.label1);
            this.grbDatosAlumno.Controls.Add(this.label2);
            this.grbDatosAlumno.Controls.Add(this.label3);
            this.grbDatosAlumno.Location = new System.Drawing.Point(347, 12);
            this.grbDatosAlumno.Name = "grbDatosAlumno";
            this.grbDatosAlumno.Size = new System.Drawing.Size(375, 255);
            this.grbDatosAlumno.TabIndex = 1;
            this.grbDatosAlumno.TabStop = false;
            this.grbDatosAlumno.Text = "Datos Alumno";
            // 
            // txbDatAluApellido
            // 
            this.txbDatAluApellido.Location = new System.Drawing.Point(70, 55);
            this.txbDatAluApellido.Name = "txbDatAluApellido";
            this.txbDatAluApellido.Size = new System.Drawing.Size(262, 20);
            this.txbDatAluApellido.TabIndex = 16;
            // 
            // txtDatAlumNombre
            // 
            this.txtDatAlumNombre.Location = new System.Drawing.Point(70, 27);
            this.txtDatAlumNombre.Name = "txtDatAlumNombre";
            this.txtDatAlumNombre.Size = new System.Drawing.Size(262, 20);
            this.txtDatAlumNombre.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Año";
            // 
            // cbDatAluDivision
            // 
            this.cbDatAluDivision.FormattingEnabled = true;
            this.cbDatAluDivision.Location = new System.Drawing.Point(70, 138);
            this.cbDatAluDivision.Name = "cbDatAluDivision";
            this.cbDatAluDivision.Size = new System.Drawing.Size(121, 21);
            this.cbDatAluDivision.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "División";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Legajo";
            // 
            // txbDatAluLegajo
            // 
            this.txbDatAluLegajo.Location = new System.Drawing.Point(70, 85);
            this.txbDatAluLegajo.Name = "txbDatAluLegajo";
            this.txbDatAluLegajo.Size = new System.Drawing.Size(262, 20);
            this.txbDatAluLegajo.TabIndex = 20;
            // 
            // nudDatAluAño
            // 
            this.nudDatAluAño.Location = new System.Drawing.Point(70, 111);
            this.nudDatAluAño.Name = "nudDatAluAño";
            this.nudDatAluAño.Size = new System.Drawing.Size(120, 20);
            this.nudDatAluAño.TabIndex = 14;
            this.nudDatAluAño.ValueChanged += new System.EventHandler(this.nudDatAluAño_ValueChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(209, 191);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 58);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(13, 274);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(709, 169);
            this.rtbDatos.TabIndex = 2;
            this.rtbDatos.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 446);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.grbDatosAlumno);
            this.Controls.Add(this.gbDatosCurso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDatosCurso.ResumeLayout(false);
            this.gbDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDatCurAño)).EndInit();
            this.grbDatosAlumno.ResumeLayout(false);
            this.grbDatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDatAluAño)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosCurso;
        private System.Windows.Forms.DateTimePicker dtpDatCurIngreso;
        private System.Windows.Forms.TextBox tbDatCurDni;
        private System.Windows.Forms.TextBox tbDatCurApellido;
        private System.Windows.Forms.TextBox tbDatCurNombre;
        private System.Windows.Forms.ComboBox cbDatAluCurso;
        private System.Windows.Forms.NumericUpDown nudDatCurAño;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.GroupBox grbDatosAlumno;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown nudDatAluAño;
        private System.Windows.Forms.TextBox txbDatAluLegajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDatAluDivision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDatAluApellido;
        private System.Windows.Forms.TextBox txtDatAlumNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDatos;
    }
}

