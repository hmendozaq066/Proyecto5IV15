using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02.Modelos
{
    //Usuario hereda de modelo
    class Usuario : Modelo
    {
        //Agregar el constructor
        //Constructor se llama igual que la clase y no devuelve algún valor
        public Usuario()
        {
            Tabla = "usuario";
            PK = "usuario_id";
            NuevoRegistro = true;
        }

        public bool ValidarUsuario()
        {
            string query = string.Format("SELECT * FROM {0} WHERE correo = @correo AND contrasenha = @contrasenha", Tabla);
            return true;
        }

    }
}
