using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica02.Modelos;

namespace Practica02
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var usuario = new Usuario();
            var usuario = new Actividad();
            //usuario.Tabla = "actividad";
            dataGridView1.DataSource = usuario.ObtenerRegistros();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();

            usuario.Correo = "hmendozaq@gmail.com";
            usuario.Contrasenha = "123456";

            if (usuario.ValidarUsuario())
            {
                MessageBox.Show("Usuario valido");
            }
            else
            {
                MessageBox.Show("Usuario invalido");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();

            usuario.Correo = "uncorreo@correo.com";
            usuario.Contrasenha = "123456789";
            usuario.Rol = "usuario";

            if(usuario.Guardar() == true)
            {
                MessageBox.Show("Usuario guardado correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo guardar");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.UsuarioID = 15;

            if (usuario.Eliminar())
            {
                MessageBox.Show("Usuario eliminado");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.UsuarioID = 2;
            usuario.Correo = "otrocorreo@.correo.com";
            usuario.Contrasenha = "987654";
            usuario.Estado = 1;
            usuario.Rol = "usuario";

            if (usuario.Actualizar())
            {
                MessageBox.Show("El usuario se actualizo");
            }
            else
            {
                MessageBox.Show("El usuario no se pudo actualizar");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var actividad = new Actividad();
            actividad.ActividadN = "Desde VS2019";
            actividad.Horas = 10;

            if (actividad.Guardar())
            {
                MessageBox.Show("Actividad guardada correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo guardar la actividad");
            }

        }
    }
}
