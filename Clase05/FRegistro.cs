using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase05.Clase;

namespace Clase05
{
    public partial class FRegistro : Form
    {
        public FRegistro()
        {
            InitializeComponent();
        }

        private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBox con la propiedad Checked nos indica si esta seleccionado o no
            //MessageBox.Show("El valor del check es" + chkMostrarContrasena.Checked.ToString());
            //Si checkbox esta seleccionado entonces
            if(chkMostrarContrasena.Checked == true)
            {
                //Quitar el caracter del password char y muestra la contraseña
                txtContrasena.PasswordChar = '\0';
                //Deshabilitar el textbox de repetir contraseña
                txtRepetirContrasena.Enabled = false;
            }
            else //Si no esta seleccionado entonces hace esto
            {
                //Vuelve a establecer a * como caracter de contraseña
                txtContrasena.PasswordChar = '*';
                //Habilita el textbox de repetir contraseña
                txtRepetirContrasena.Enabled = true;
            }
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("Puntero del mouse encima del control");
            //btnCancelar.Location = new Point(0, 0);
            //Random aleatorio = new Random();
            //btnCancelar.Location = new Point(aleatorio.Next(0, 500), aleatorio.Next(0, 500));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Texto a mostrar");
            //MessageBox.Show("Texto a mostrar", "Titulo");
            //MessageBox.Show("Texto a mostrar", "Titulo", MessageBoxButtons.YesNo);
            //MessageBox.Show("Texto a mostrar", "Titulo", MessageBoxButtons.OKCancel);
            //MessageBox.Show("Texto a mostrar", "Titulo", MessageBoxButtons.YesNoCancel);
            //MessageBox.Show("Texto a mostrar", "Titulo", MessageBoxButtons.AbortRetryIgnore);
            //MessageBox.Show("Texto a mostrar", "Titulo", MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            //MessageBox.Show("Texto a mostrar", "Titulo", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            //MessageBox.Show("Texto a mostrar", "Titulo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            var resultado = MessageBox.Show("¿Deseas cancelar el registro?", "Clase05", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            if(chkMostrarContrasena.Checked == false && txtContrasena.Text != txtRepetirContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else
            {
                usuario.NombreUsuario = txtUsuario.Text;
                usuario.Contrasena = txtContrasena.Text;
                usuario.CorreoElectronico = txtCorreoElectronico.Text;
                usuario.FechaNacimiento = dtFechaNacimiento.Value;
                usuario.Genero = cbGenero.Text;
                usuario.Semestre = Convert.ToInt32(nSemestre.Value);
                usuario.NumeroTelefono = txtNumeroTelefonico.Text;
                usuario.CURP = txtCurp.Text;

                if(usuario.Validar())
                {
                    //Guardar el registro
                    if (usuario.Guardar())
                    {
                        MessageBox.Show("Usuario guardado", "CLASE05");
                    }
                }
                else
                {
                    //string.Join(Environment.NewLine, usuario.GetErrores()) ==> Convierte un lista de string en un string con el separador Environment.NewLine
                    //Environment.NewLine indica un salto de linea
                    MessageBox.Show("Ocurrieron los siguiente errores:" + Environment.NewLine + Environment.NewLine + string.Join(Environment.NewLine, usuario.GetErrores()), "Clase05", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
