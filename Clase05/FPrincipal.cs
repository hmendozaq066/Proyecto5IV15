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
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            dgvUsuarios.DataSource = usuario.CargarUsuarios();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var registro = new FRegistro();
            registro.ShowDialog();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            dgvUsuarios.DataSource = usuario.CargarUsuarios();
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
                e.Cancel = false;
                //Application.Exit();
            }
        }
    }
}
