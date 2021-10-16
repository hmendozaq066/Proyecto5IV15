
namespace Clase06
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.dgvMostrarDatos = new System.Windows.Forms.DataGridView();
            this.btnTraerDatos = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnTraerDatosFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(12, 12);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // dgvMostrarDatos
            // 
            this.dgvMostrarDatos.AllowUserToAddRows = false;
            this.dgvMostrarDatos.AllowUserToDeleteRows = false;
            this.dgvMostrarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarDatos.Location = new System.Drawing.Point(12, 84);
            this.dgvMostrarDatos.Name = "dgvMostrarDatos";
            this.dgvMostrarDatos.ReadOnly = true;
            this.dgvMostrarDatos.Size = new System.Drawing.Size(1042, 285);
            this.dgvMostrarDatos.TabIndex = 1;
            // 
            // btnTraerDatos
            // 
            this.btnTraerDatos.Location = new System.Drawing.Point(93, 12);
            this.btnTraerDatos.Name = "btnTraerDatos";
            this.btnTraerDatos.Size = new System.Drawing.Size(104, 23);
            this.btnTraerDatos.TabIndex = 2;
            this.btnTraerDatos.Text = "Traer datos";
            this.btnTraerDatos.UseVisualStyleBackColor = true;
            this.btnTraerDatos.Click += new System.EventHandler(this.btnTraerDatos_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(203, 15);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(147, 20);
            this.txtFiltro.TabIndex = 3;
            // 
            // btnTraerDatosFiltro
            // 
            this.btnTraerDatosFiltro.Location = new System.Drawing.Point(356, 12);
            this.btnTraerDatosFiltro.Name = "btnTraerDatosFiltro";
            this.btnTraerDatosFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnTraerDatosFiltro.TabIndex = 4;
            this.btnTraerDatosFiltro.Text = "Consultar";
            this.btnTraerDatosFiltro.UseVisualStyleBackColor = true;
            this.btnTraerDatosFiltro.Click += new System.EventHandler(this.btnTraerDatosFiltro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 679);
            this.Controls.Add(this.btnTraerDatosFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnTraerDatos);
            this.Controls.Add(this.dgvMostrarDatos);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.DataGridView dgvMostrarDatos;
        private System.Windows.Forms.Button btnTraerDatos;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnTraerDatosFiltro;
    }
}

