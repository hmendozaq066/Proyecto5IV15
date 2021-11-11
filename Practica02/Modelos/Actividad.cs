using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica02.Modelos
{
    //Actividad hereda a Modelo
    //Actividad es una clase hija de Modelo, por lo tanto herera las propiedades y métodos publicos y protegidos
    //NO HEREDA LAS PRIVADAS
    //La clase base de Actividad es Modelo
    class Actividad : Modelo
    {
        public int Actividad_id { get; set; }
        public string ActividadN { get; set; }
        public int Horas { get; set; }
        //Constructor
        public Actividad()
        {
            Tabla = "actividad";
            PK = "actividad_id";
            NuevoRegistro = true;
        }

        public bool Guardar()
        {
            //Aqui empieza a insertar el registro
            string query = "INSERT INTO actividad(actividad, horas) VALUES(@actividad, @horas)";
            //Para hacer insert/update/delete se necesita un objeto sqlcommand
            var comando = new SqlCommand(query, new SqlConnection());
            //Si hay parametros se deben agregar
            comando.Parameters.AddWithValue("@actividad", ActividadN);
            comando.Parameters.AddWithValue("@horas", Horas);
            //Almacenamos el resultado de la ejecución (este devuelve las filas afectadas)
            int resultado = Ejecutar(comando);
            //Si es mayor a cero devuelve true de lo contrario false
            return (resultado > 0) ? true : false;
        }
    }
}
