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
using System.IO;

namespace Clase05
{
    public partial class FPrincipal : Form
    {
        //Declarando una variable privada "GLOBAL" disponible mientras el formulario esta activo
        private List<Usuario> _usuarios = new List<Usuario>();

        public FPrincipal()
        {
            InitializeComponent();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            _usuarios = usuario.CargarUsuarios();
            dgvUsuarios.DataSource = _usuarios;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var registro = new FRegistro();
            registro.ShowDialog();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            _usuarios = usuario.CargarUsuarios();
            dgvUsuarios.DataSource = _usuarios;
        }

        private void FPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resultado = MessageBox.Show("¿Realmente deseas salir?", "CLASE05", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                //COn esta linea se evita que aparezca dos veces la pregunta de deseo salir
                //this.FormClosing -=  Se queda tal cual
                //FPrincipal_FormClosing; es el nombre del métod que lo llama, 
                this.FormClosing -= FPrincipal_FormClosing;
                //e.Cancel = false;
                Application.Exit();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvUsuarios.SelectedRows.Count.ToString());
            //Aquí estamos averiguando si hay una fila seleccionada del DataGridView
            if(dgvUsuarios.SelectedRows.Count > 0)
            {
                //Si esta fila esta seleccionada obetenemos el valor de la celda con posición, en este caso 1.
                //Hay que recordar que las columnas empiezan con valor de 0 a (n-1)
                var nombre = dgvUsuarios.SelectedRows[0].Cells[1].Value.ToString();
                //Aquí estamos preguntando si queremos eliminar al usuario
                if (MessageBox.Show("¿Deseas eliminar al usuario " + nombre + "?", "CLASE05", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Si nos dicen que si, buscamos en la lista _usuario el item que tiene como NombreUsuario el nombre
                    var eliminar = _usuarios.Single(x => x.NombreUsuario == nombre);//Buscamos el elemento a eliminar
                    //Eliminamos el elemento encontrado
                    _usuarios.Remove(eliminar);//Eliminamos el elemento
                    //Ponemos el DataGridView.Datasource en null para que no exista un error de selección
                    dgvUsuarios.DataSource = null; //Evitar el error de la carga 
                    //Volvemos a cargar la lista _usuarios de la variable "GLOBAL"
                    dgvUsuarios.DataSource = _usuarios;
                    //Llamamos al método sobreescribir
                    SobreescribirContactos();
                }
                //MessageBox.Show(dgvUsuarios.SelectedRows[0].Cells[3].Value.ToString());
            }
        }

        private bool SobreescribirContactos()
        {
            //Eliminamos el archivo usuarios.txt
            File.Delete(@".\usuarios.txt");
            //Creamos uno nuevo
            StreamWriter file = new StreamWriter(@".\usuarios.txt", append: true);
            //recorremos la lista _usuarios (que tiene a los usuarios activos
            foreach(Usuario u in _usuarios)
            {
                //Escribimos linea por linea el nombre de los usuarios
                file.WriteLine(u.GenerarLinea());
            }            
            //cerramos el archivo
            file.Close();
            return true;
        }
    }
}
