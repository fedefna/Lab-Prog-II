using Entidades;

namespace GUI
{
    partial class FormConNombre
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMemoria = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.nudMemoria = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnSystemInfo = new System.Windows.Forms.Button();
            this.rtxtSystemInfo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMemoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(69, 52);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(69, 78);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMemoria
            // 
            this.lblMemoria.AutoSize = true;
            this.lblMemoria.Location = new System.Drawing.Point(69, 111);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(72, 13);
            this.lblMemoria.TabIndex = 2;
            this.lblMemoria.Text = "Memoria (MB)";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(159, 44);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(159, 71);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 4;
            // 
            // nudMemoria
            // 
            this.nudMemoria.Location = new System.Drawing.Point(159, 104);
            this.nudMemoria.Name = "nudMemoria";
            this.nudMemoria.Size = new System.Drawing.Size(120, 20);
            this.nudMemoria.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(159, 144);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(240, 144);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 7;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnSystemInfo
            // 
            this.btnSystemInfo.Location = new System.Drawing.Point(159, 173);
            this.btnSystemInfo.Name = "btnSystemInfo";
            this.btnSystemInfo.Size = new System.Drawing.Size(156, 50);
            this.btnSystemInfo.TabIndex = 8;
            this.btnSystemInfo.Text = "System Info";
            this.btnSystemInfo.UseVisualStyleBackColor = true;
            this.btnSystemInfo.Click += new System.EventHandler(this.btnSystemInfo_Click);
            // 
            // rtxtSystemInfo
            // 
            this.rtxtSystemInfo.Location = new System.Drawing.Point(72, 238);
            this.rtxtSystemInfo.Name = "rtxtSystemInfo";
            this.rtxtSystemInfo.Size = new System.Drawing.Size(243, 148);
            this.rtxtSystemInfo.TabIndex = 9;
            this.rtxtSystemInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 398);
            this.Controls.Add(this.rtxtSystemInfo);
            this.Controls.Add(this.btnSystemInfo);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudMemoria);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMemoria);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Name = "Form1";
            this.Text = "Alaniz.FedericoNicolas.2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMemoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.NumericUpDown nudMemoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnSystemInfo;
        private System.Windows.Forms.RichTextBox rtxtSystemInfo;
    }
}

