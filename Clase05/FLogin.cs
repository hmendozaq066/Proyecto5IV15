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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola");
            //txtUsuario.Location = new Point(10, 10);
            if(txtUsuario.Text == "hmendozaq" && txtContrasena.Text == "123456")
            {
                //Muestra un mensaje
                MessageBox.Show("Bienvenido");
                //Oculta el formulario actual
                this.Hide();
                //Generando una nueva instancia de la clase FPrincipal
                var fPrincipal = new FPrincipal();
                //Mostrando el formulario
                fPrincipal.Show();
                //Este metodo es pare cerrar una ventana
                //Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto");
            }
        }

        private void lkRegistrarme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fRegistro = new FRegistro();
            //ShowDialog muestra el formulario sin permitir el regreso al 
            //formulario que lo llamo hasta que sea cerrado
            fRegistro.ShowDialog();
        }
    }
}
