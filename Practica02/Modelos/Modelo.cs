﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Practica02.Modelos
{
    //Aquí estamos indicando que hay una herencia, la clase base es CDAO y la clase hija es Modelo
    class Modelo : CDAO
    {
        public bool NuevoRegistro { get; set; }
        public string Tabla { get; set; }
        public string PK { get; set; }

        /// <summary>
        /// Este método es de la clase Modelo, y obtiene todos los registros de la tabla indicada
        /// </summary>
        /// <returns>Un DataTable con los registros obtenidos</returns>
        public DataTable ObtenerRegistros()
        {
            var adapter = new SqlDataAdapter();
            var query = String.Format("SELECT * FROM {0};", Tabla);
            adapter.SelectCommand.CommandText = query;
            return Consultar(adapter);
        }

        /// <summary>
        /// Este método es de la clase Modelo y obtiene UN registro con el filtro aplicado
        /// </summary>
        /// <param name="ID">ID a buscar</param>
        /// <returns>Una fila con el registro si es localizado, de lo contrario devuelve null</returns>
        public DataRow ObtenerRegistroPorID(int ID)
        {
            var query = string.Format("SELECT * FROM {0} WHERE {1} = @PK", Tabla, PK);
            var adapter = new SqlDataAdapter(null, query);
            adapter.SelectCommand.Parameters.AddWithValue("@PK", ID);
            var resultado = Consultar(adapter);
            
            if (resultado.Rows.Count > 0) return resultado.Rows[0];
            
            return null;
        }
    }
}
