using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica02.Modelos
{
    //Usuario hereda de modelo
    class Usuario : Modelo
    {

        public int UsuarioID { get; set; }
        public string Correo { get; set; }
        public string Contrasenha { get; set; }
        public int IntentosFallidos { get; set; }
        public DateTime UltimoAcceso { get; set; }
        public string Rol { get; set; }
        public int Estado { get; set; }

        //Agregar el constructor
        //Constructor se llama igual que la clase y no devuelve algún valor
        public Usuario()
        {
            Tabla = "usuario";
            PK = "usuario_id";
            NuevoRegistro = true;
        }
        //Este método es único para la clase usuario ya que valida
        public bool ValidarUsuario()
        {
            string query = string.Format("SELECT * FROM usuario WHERE correo = @correo;");
            var adapter = new SqlDataAdapter(query, new SqlConnection());
            adapter.SelectCommand.Parameters.AddWithValue("@correo", Correo);
            var resultado = Consultar(adapter);

            if(resultado.Rows.Count > 0)
            {
                //Que si existe el usuario

                if(Convert.ToInt32(resultado.Rows[0][3]) > 3)
                {
                    return false;
                }

                if(resultado.Rows[0][2].ToString() == Contrasenha)
                {
                    return true;
                }

                query = "UPDATE usuario SET intentos_fallidos = intentos_fallidos + 1 WHERE correo = @correo;";
                var comando = new SqlCommand(query, new SqlConnection());
                comando.Parameters.AddWithValue("@correo", Correo);
                Ejecutar(comando);
            }

            return false;
        }

        public bool Guardar()
        {
            //Con esta sección se evita la duplicidad del correo
            string query = string.Format("SELECT * FROM usuario WHERE correo = @correo;");
            var adapter = new SqlDataAdapter(query, new SqlConnection());
            adapter.SelectCommand.Parameters.AddWithValue("@correo", Correo);
            var registros = Consultar(adapter);

            if (registros.Rows.Count > 0)
            {
                return false;
            }
            //Hasta aqui termina la duplicidad de usuario

            //Aqui empieza a insertar el registro
            query = "INSERT INTO usuario(correo, contrasenha, rol) VALUES(@correo, @contrasenha, @rol);";
            //Para hacer insert/update/delete se necesita un objeto sqlcommand
            var comando = new SqlCommand(query, new SqlConnection());
            //Si hay parametros se deben agregar
            comando.Parameters.AddWithValue("@correo", Correo);
            comando.Parameters.AddWithValue("@contrasenha", Contrasenha);
            comando.Parameters.AddWithValue("@rol", Rol);
            //Almacenamos el resultado de la ejecución (este devuelve las filas afectadas)
            int resultado = Ejecutar(comando);
            //Si es mayor a cero devuelve true de lo contrario false
            return (resultado > 0) ? true : false;
        }

        public bool Eliminar()
        {
            string query = "DELETE FROM usuario WHERE usuario_id = @usuario_id;";
            var comando = new SqlCommand(query, new SqlConnection());
            comando.Parameters.AddWithValue("@usuario_id", UsuarioID);
            int resultado = Ejecutar(comando);
            
            if (resultado > 0) return true;

            return false;
        }

        public bool Actualizar()
        {
            string query = "UPDATE usuario SET correo = @correo, contrasenha = @contrasenha, rol = @rol, estado = @estado WHERE usuario_id = @usuario_id;";
            var comando = new SqlCommand(query, new SqlConnection());
            comando.Parameters.AddWithValue("@correo", Correo);
            comando.Parameters.AddWithValue("@contrasenha", Contrasenha);
            comando.Parameters.AddWithValue("@rol", Rol);
            comando.Parameters.AddWithValue("@estado", Estado);
            comando.Parameters.AddWithValue("@usuario_id", UsuarioID);

            int resultado = Ejecutar(comando);

            if(resultado > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }




    }
}
