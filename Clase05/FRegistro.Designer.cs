
namespace Clase05
{
    partial class FRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRegistro));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtRepetirContrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkMostrarContrasena = new System.Windows.Forms.CheckBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nSemestre = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumeroTelefonico = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nSemestre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(16, 32);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(265, 27);
            this.txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(16, 97);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(179, 27);
            this.txtContrasena.TabIndex = 3;
            // 
            // txtRepetirContrasena
            // 
            this.txtRepetirContrasena.Location = new System.Drawing.Point(16, 161);
            this.txtRepetirContrasena.Name = "txtRepetirContrasena";
            this.txtRepetirContrasena.PasswordChar = '*';
            this.txtRepetirContrasena.Size = new System.Drawing.Size(265, 27);
            this.txtRepetirContrasena.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repetir contraseña:";
            // 
            // chkMostrarContrasena
            // 
            this.chkMostrarContrasena.AutoSize = true;
            this.chkMostrarContrasena.Location = new System.Drawing.Point(201, 100);
            this.chkMostrarContrasena.Name = "chkMostrarContrasena";
            this.chkMostrarContrasena.Size = new System.Drawing.Size(86, 24);
            this.chkMostrarContrasena.TabIndex = 6;
            this.chkMostrarContrasena.Text = "Mostrar";
            this.chkMostrarContrasena.UseVisualStyleBackColor = true;
            this.chkMostrarContrasena.CheckedChanged += new System.EventHandler(this.chkMostrarContrasena_CheckedChanged);
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(16, 225);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(265, 27);
            this.txtCorreoElectronico.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Correo electrónico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de nacimiento:";
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.CustomFormat = "yyyy-MM-dd";
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(16, 291);
            this.dtFechaNacimiento.MaxDate = new System.DateTime(2021, 10, 5, 0, 0, 0, 0);
            this.dtFechaNacimiento.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(265, 27);
            this.dtFechaNacimiento.TabIndex = 10;
            this.dtFechaNacimiento.Value = new System.DateTime(2021, 10, 5, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Género:";
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbGenero.Location = new System.Drawing.Point(16, 354);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(265, 28);
            this.cbGenero.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Semestre:";
            // 
            // nSemestre
            // 
            this.nSemestre.Location = new System.Drawing.Point(16, 417);
            this.nSemestre.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nSemestre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nSemestre.Name = "nSemestre";
            this.nSemestre.Size = new System.Drawing.Size(265, 27);
            this.nSemestre.TabIndex = 14;
            this.nSemestre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Número telefónico:";
            // 
            // txtNumeroTelefonico
            // 
            this.txtNumeroTelefonico.Location = new System.Drawing.Point(16, 481);
            this.txtNumeroTelefonico.Mask = "(+52) 00-0000-0000";
            this.txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            this.txtNumeroTelefonico.Size = new System.Drawing.Size(265, 27);
            this.txtNumeroTelefonico.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "CURP:";
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(16, 549);
            this.txtCurp.Mask = "LLLL000000LLLLLLAA";
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(265, 27);
            this.txtCurp.TabIndex = 18;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(173, 593);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 33);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(55, 593);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(108, 33);
            this.btnRegistrar.TabIndex = 20;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 644);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtCurp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNumeroTelefonico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nSemestre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtFechaNacimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkMostrarContrasena);
            this.Controls.Add(this.txtRepetirContrasena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registo";
            ((System.ComponentModel.ISupportInitialize)(this.nSemestre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtRepetirContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkMostrarContrasena;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nSemestre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtNumeroTelefonico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtCurp;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}