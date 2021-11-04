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
    }
}
