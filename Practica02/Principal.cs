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
            dgvTabla.DataSource = usuario.ObtenerRegistros();
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

        private void Principal_Load(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            dgvTabla.DataSource = usuario.ObtenerRegistros();
        }

        private void dgvTabla_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             Interceptamos el evento doble clic del control DataGridView que se llama dgvTabla

            Para obtener los valores de la fila seleccionada se usa la siguiente linea, el indice de SelectedCells se debe indicar
            la columna de la cual se obtendran los datos empezando por 0
            dataGridView.SelectedCells[0].Value.ToString()
             */
            //MessageBox.Show("Doble clic"); dataGridView1.SelectedCells[0].Value.ToString()

            txtID.Text = dgvTabla.SelectedCells[0].Value.ToString();
            txtCorreo.Text = dgvTabla.SelectedCells[1].Value.ToString();
            txtContrasenha.Text = dgvTabla.SelectedCells[2].Value.ToString();
            txtIntentosFallidos.Text = dgvTabla.SelectedCells[3].Value.ToString();
            cbRol.Text = dgvTabla.SelectedCells[5].Value.ToString();
            cbEstado.Text = (dgvTabla.SelectedCells[6].Value.ToString() == "1") ? "Activo" : "Desactivado";
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Generanos una nuevo objeto de tipo usuario el cual se llenaran dus datos
            //para poder realizar una actualización
            var usuario = new Usuario();
            usuario.UsuarioID = Convert.ToInt32(txtID.Text);
            usuario.Correo = txtCorreo.Text;
            usuario.Contrasenha = txtContrasenha.Text;
            usuario.IntentosFallidos = Convert.ToInt32(txtIntentosFallidos.Text);
            usuario.Rol = cbRol.Text;
            usuario.Estado = (cbEstado.Text == "Activo") ? 1 : 2;

            if (usuario.Actualizar())
            {
                LimpiarFormulario();
                MessageBox.Show("Usuario actualizado");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el usuario");
            }

        }
        //Limpiar formulario es un método privado el cual limpia el formulario
        //Para una mejor control de código, en tareas repetitivas es mejor hacer un método para llamarlo después
        //Con esto evitamos posibles errores 
        private void LimpiarFormulario()
        {
            var usuario = new Usuario();
            txtID.Clear();
            txtCorreo.Clear();
            txtContrasenha.Clear();
            txtIntentosFallidos.Clear();
            cbRol.Text = string.Empty;
            cbEstado.Text = string.Empty;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;
            dgvTabla.DataSource = usuario.ObtenerRegistros();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Aquí mandamos un mensaje y guardamos el resultado
            var respuesta = MessageBox.Show("¿Deseas eliminar el registro", "Practica02", MessageBoxButtons.YesNo);

            //Verificamos ese resultado y ejecutamos el código conforme a nuestra lógica de negocio
            if(respuesta == DialogResult.Yes)
            {
                var usuario = new Usuario();
                usuario.UsuarioID = Convert.ToInt32(txtID.Text);

                if (usuario.Eliminar())
                {
                    LimpiarFormulario();
                    MessageBox.Show("Se elimino correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario");
                }

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Correo = txtCorreo.Text;
            usuario.Contrasenha = txtContrasenha.Text;
            usuario.IntentosFallidos = Convert.ToInt32(txtIntentosFallidos.Text);
            usuario.Rol = cbRol.Text;
            usuario.Estado = (cbEstado.Text == "Activo") ? 1 : 2;

            if (usuario.Guardar())
            {
                LimpiarFormulario();
                MessageBox.Show("Usuario actualizado");
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el usuario");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();

            if (string.IsNullOrEmpty(txtCriterio.Text) || string.IsNullOrEmpty(cbFiltro.Text))
            {
                dgvTabla.DataSource = usuario.ObtenerRegistros();
            }
            else
            {
                LimpiarFormulario();
                
                var resultados = usuario.Buscar(txtCriterio.Text, cbFiltro.Text);

                dgvTabla.DataSource = resultados;

                if (resultados.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var actividad = new Actividad();
            actividad.ActividadN = "Actividad desde C# con SP";
            actividad.Horas = 3;

            if (actividad.GuardarSP())
            {
                MessageBox.Show("Actividad guardada");
            }
            else
            {
                MessageBox.Show("No se pudo guardar");
            }
        }
    }
}
