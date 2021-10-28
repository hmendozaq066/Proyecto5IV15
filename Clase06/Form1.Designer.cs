
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnValidarUsuario = new System.Windows.Forms.Button();
            this.btnInsertarParametrizado = new System.Windows.Forms.Button();
            this.btnValidarUsuarioCorrecto = new System.Windows.Forms.Button();
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
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(15, 409);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(304, 29);
            this.txtID.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 457);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(135, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(15, 496);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(135, 20);
            this.txtApellidos.TabIndex = 7;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(15, 535);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(135, 20);
            this.txtCorreo.TabIndex = 8;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(15, 574);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(1039, 20);
            this.txtGenero.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(12, 441);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 11;
            this.Nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Género";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(355, 406);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(145, 23);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar (Concatenado)";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(15, 600);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(1039, 47);
            this.txtConsulta.TabIndex = 16;
            // 
            // btnValidarUsuario
            // 
            this.btnValidarUsuario.Location = new System.Drawing.Point(506, 406);
            this.btnValidarUsuario.Name = "btnValidarUsuario";
            this.btnValidarUsuario.Size = new System.Drawing.Size(170, 23);
            this.btnValidarUsuario.TabIndex = 17;
            this.btnValidarUsuario.Text = "Validar usuario (concat)";
            this.btnValidarUsuario.UseVisualStyleBackColor = true;
            this.btnValidarUsuario.Click += new System.EventHandler(this.btnValidarUsuario_Click);
            // 
            // btnInsertarParametrizado
            // 
            this.btnInsertarParametrizado.Location = new System.Drawing.Point(356, 431);
            this.btnInsertarParametrizado.Name = "btnInsertarParametrizado";
            this.btnInsertarParametrizado.Size = new System.Drawing.Size(144, 23);
            this.btnInsertarParametrizado.TabIndex = 18;
            this.btnInsertarParametrizado.Text = "Insertar (parámetros)";
            this.btnInsertarParametrizado.UseVisualStyleBackColor = true;
            this.btnInsertarParametrizado.Click += new System.EventHandler(this.btnInsertarParametrizado_Click);
            // 
            // btnValidarUsuarioCorrecto
            // 
            this.btnValidarUsuarioCorrecto.Location = new System.Drawing.Point(506, 431);
            this.btnValidarUsuarioCorrecto.Name = "btnValidarUsuarioCorrecto";
            this.btnValidarUsuarioCorrecto.Size = new System.Drawing.Size(170, 23);
            this.btnValidarUsuarioCorrecto.TabIndex = 19;
            this.btnValidarUsuarioCorrecto.Text = "Validar Usuario (parámetros)";
            this.btnValidarUsuarioCorrecto.UseVisualStyleBackColor = true;
            this.btnValidarUsuarioCorrecto.Click += new System.EventHandler(this.btnValidarUsuarioCorrecto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 679);
            this.Controls.Add(this.btnValidarUsuarioCorrecto);
            this.Controls.Add(this.btnInsertarParametrizado);
            this.Controls.Add(this.btnValidarUsuario);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnTraerDatosFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnTraerDatos);
            this.Controls.Add(this.dgvMostrarDatos);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnValidarUsuario;
        private System.Windows.Forms.Button btnInsertarParametrizado;
        private System.Windows.Forms.Button btnValidarUsuarioCorrecto;
    }
}

