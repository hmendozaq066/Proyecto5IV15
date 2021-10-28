using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clase06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            // Para datos de prueba https://www.mockaroo.com/
            //1- Agregar los using necesarios using System.Data.SqlClient;
            //2. Para la conexión se necesita la "cadena de conexion"  https://www.connectionstrings.com/ >> SQL Server >> Trusted Connection
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
            //Server=Nombre del servidor (DESKTOP-0HLSANU)
            //Database=Nombre de la base de datos (prueba01)
            //Quedando de la siguiente forma: Server=DESKTOP-0HLSANU;Database=prueba01;Trusted_Connection=True;
            //3.- Realizar la conexión con el objero SQLConnection

            var cadenaConexion = "Server=DESKTOP-0HLSANU;Database=prueba01;Trusted_Connection=True;";
            var sqlCnn = new SqlConnection(cadenaConexion);//Nos pide como parámetro el la cadena de conexion
            sqlCnn.Open(); //Se abre la conexión
            MessageBox.Show("Conexión abierta");

            //CUANDO APAREZCA ESTE ERROR SIGNIFICA QUE EL NOMBRE DEL SERVIDOR ESTA MAL ESCRITO O EL SERVIDOR
            //NO ESTA ACTIVO
            /* Error relacionado con la red o específico de la instancia mientras se establecía una conexión con el 
             * servidor SQL Server. No se encontró el servidor o éste no estaba accesible. Compruebe que el nombre 
             * de la instancia es correcto y que SQL Server está configurado para admitir conexiones remotas. 
             * (provider: Named Pipes Provider, error: 40 - No se pudo abrir una conexión con SQL Server)*/
        }

        private void btnTraerDatos_Click(object sender, EventArgs e)
        {
            var cadenaConexion = "Server=DESKTOP-0HLSANU;Database=prueba01;Trusted_Connection=True;";
            var sqlCnn = new SqlConnection(cadenaConexion);//Nos pide como parámetro el la cadena de conexion
            sqlCnn.Open(); //Se abre la conexión
            //El SQLDataAdapter es para mandar la consulta al servidor
            var adapter = new SqlDataAdapter("SELECT usuario_id As ID, Apellidos, Nombre, Correo, genero as Género FROM usuarios", sqlCnn);
            var tabla = new DataTable();//DataTable es un objeto que nos permite guardar información de forma temporal
            adapter.Fill(tabla);//Fill es un método de dataAdapter para llenar una tabla

            dgvMostrarDatos.DataSource = tabla;//gdv Es un datagridview que muestra la información almancenada en un datatable o lista

            //CUANDO EL NOMBRE DE UN CAMPO (COLUMNA) DE TABLA ESTA MAL ESCRITA APARECE ESTE ERROR
            //'Invalid column name 'usuario_i'.'

            //CUANDO EL NOMBRE DE LA BASE DE DATOS ESTA MAL ESCRITA O NO EXISTE APARECE ESTE ERROR
            //Cannot open database "prueba1" requested by the login. The login failed. Login failed for user 'DESKTOP-0HLSANU\hmendozaq'.'

        }

        private void btnTraerDatosFiltro_Click(object sender, EventArgs e)
        {
            var cadenaConexion = "Server=DESKTOP-0HLSANU;Database=prueba01;Trusted_Connection=True;";
            var sqlCnn = new SqlConnection(cadenaConexion);//Nos pide como parámetro el la cadena de conexion
            sqlCnn.Open(); //Se abre la conexión
            //El SQLDataAdapter es para mandar la consulta al servidor
            var query = "SELECT * FROM usuarios WHERE nombre LIKE '%" + txtFiltro.Text + "%';";
            var adapter = new SqlDataAdapter(query , sqlCnn);
            var tabla = new DataTable();//DataTable es un objeto que nos permite guardar información de forma temporal
            adapter.Fill(tabla);//Fill es un método de dataAdapter para llenar una tabla

            dgvMostrarDatos.DataSource = tabla;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var cadenaConexion = "Server=DESKTOP-0HLSANU;Database=prueba01;Trusted_Connection=True;";
            var sqlCnn = new SqlConnection(cadenaConexion);//Nos pide como parámetro el la cadena de conexion
            sqlCnn.Open(); //Se abre la conexión
            //var query = "INSERT INTO usuarios(usuario_id, nombre, apellidos, correo, genero) VALUES(@usuario_id, @nombre, @apellidos, @correo, @genero)";
            //ESTO ES LO PEOR QUE PUEDEN HACER EN UN PROYECTO
            //DEBEN EVITAR CONCATENAR CADENAS EN UNA CONSULTA SQL
            var query = string.Format("INSERT INTO usuarios(usuario_id, nombre, apellidos, correo, genero) VALUES({0}, '{1}', '{2}', '{3}', '{4}')",
                txtID.Text, txtNombre.Text, txtApellidos.Text, txtCorreo.Text, txtGenero.Text);
            txtConsulta.Text = query;
            var sqlCmd = new SqlCommand(query, sqlCnn);
            var resultado = sqlCmd.ExecuteNonQuery();
            txtConsulta.Text += " El numero de filas afectadas es: " + resultado.ToString();

        }

        private void btnValidarUsuario_Click(object sender, EventArgs e)
        {
            var cadenaConexion = "Server=DESKTOP-0HLSANU;Database=prueba01;Trusted_Connection=True;";
            var sqlCnn = new SqlConnection(cadenaConexion);//Nos pide como parámetro el la cadena de conexion
            sqlCnn.Open(); //Se abre la conexión
            //El SQLDataAdapter es para mandar la consulta al servidor
            var query = string.Format("SELECT * FROM usuarios WHERE correo = '{0}' AND usuario_id = '{1}';", txtCorreo.Text, txtID.Text);
            var adapter = new SqlDataAdapter(query, sqlCnn);
            var tabla = new DataTable();//DataTable es un objeto que nos permite guardar información de forma temporal
            adapter.Fill(tabla);//Fill es un método de dataAdapter para llenar una tabla
            txtConsulta.Text = query;

            if (tabla.Rows.Count > 0)
            {
                MessageBox.Show("Usuario valido");
            }
            else
            {
                MessageBox.Show("Usuario no valido");
            }
        }

        private void btnInsertarParametrizado_Click(object sender, EventArgs e)
        {
            var cadenaConexion = "Server=DESKTOP-0HLSANU;Database=prueba01;Trusted_Connection=True;";
            var sqlCnn = new SqlConnection(cadenaConexion);//Nos pide como parámetro el la cadena de conexion
            sqlCnn.Open(); //Se abre la conexión
            
            var query = "INSERT INTO usuarios(usuario_id, nombre, apellidos, correo, genero) VALUES(@usuario_id, @nombre, @apellidos, @correo, @genero)";
            var sqlCmd = new SqlCommand(query, sqlCnn);

            sqlCmd.Parameters.AddWithValue("@usuario_id", txtID.Text);
            sqlCmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            sqlCmd.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
            sqlCmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
            sqlCmd.Parameters.AddWithValue("@genero", txtGenero.Text);

            var resultado = sqlCmd.ExecuteNonQuery();
            
            if(resultado > 0)
            {
                MessageBox.Show("Registro guardado");
            }
            else
            {
                MessageBox.Show("No se pudo guardar el registro");
            }

        }

        private void btnValidarUsuarioCorrecto_Click(object sender, EventArgs e)
        {
            var cadenaConexion = "Server=DESKTOP-0HLSANU;Database=prueba01;Trusted_Connection=True;";
            var sqlCnn = new SqlConnection(cadenaConexion);//Nos pide como parámetro el la cadena de conexion
            sqlCnn.Open(); //Se abre la conexión
            //El SQLDataAdapter es para mandar la consulta al servidor
            var query = "SELECT * FROM usuarios WHERE usuario_id = @usuario_id AND correo = @correo;";
            var adapter = new SqlDataAdapter(query, sqlCnn);
            //Así se agregan los parámetros a un adapter para una consulta segura
            adapter.SelectCommand.Parameters.AddWithValue("@correo", txtCorreo.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@usuario_id", txtID.Text);

            var tabla = new DataTable();//DataTable es un objeto que nos permite guardar información de forma temporal
            adapter.Fill(tabla);//Fill es un método de dataAdapter para llenar una tabla
            txtConsulta.Text = query;

            if (tabla.Rows.Count > 0)
            {
                MessageBox.Show("Usuario valido");
            }
            else
            {
                MessageBox.Show("Usuario no valido");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
