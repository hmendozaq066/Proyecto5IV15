using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
