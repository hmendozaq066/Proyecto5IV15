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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();

            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Contrasena = txtContrasena.Text;
            
            if(usuario.ValidarUsuario() == true)
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

            //MessageBox.Show("Hola");
            //txtUsuario.Location = new Point(10, 10);
        }

        private void lkRegistrarme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fRegistro = new FRegistro();
            //ShowDialog muestra el formulario sin permitir el regreso al 
            //formulario que lo llamo hasta que sea cerrado
            fRegistro.ShowDialog();
        }

        private void pMostrarContrasena_MouseHover(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = '\0';
        }

        private void pMostrarContrasena_MouseLeave(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = '*';
        }
    }
}
