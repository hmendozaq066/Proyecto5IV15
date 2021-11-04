using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02.Modelos
{
    //Actividad hereda a Modelo
    //Actividad es una clase hija de Modelo, por lo tanto herera las propiedades y métodos publicos y protegidos
    //NO HEREDA LAS PRIVADAS
    //La clase base de Actividad es Modelo
    class Actividad : Modelo
    {
        //Constructor
        public Actividad()
        {
            Tabla = "actividad";
            PK = "actividad_id";
            NuevoRegistro = true;
        }
    }
}
