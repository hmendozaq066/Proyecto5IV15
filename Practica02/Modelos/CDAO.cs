using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Practica02.Modelos
{
    class CDAO
    {
        private SqlConnection conexion = null;
        private string cadena = @"Data Source=DESKTOP-0HLSANU;Initial Catalog=Practica02;Integrated Security=True";

        /// <summary>
        /// Este método ejecuta un sqlcommand, se usa para el INSERT, UPDATE, DELETE
        /// </summary>
        /// <param name="comando">Un objeto del SqlCommand</param>
        /// <returns>Número de registros afectados</returns>
        public int Ejecutar(SqlCommand comando)
        {
            if (conexion == null) conexion = new SqlConnection(cadena);
            if (conexion.State == System.Data.ConnectionState.Closed) conexion.Open();

            comando.Connection = conexion;
            var resultado = comando.ExecuteNonQuery();
            conexion.Close();
            return resultado;
        }

        /// <summary>
        /// Este mpetodo ejecuta un sqlDataAdapter, se usa para los SELECT
        /// </summary>
        /// <param name="adapter">Un objero del tipo SQlDataAdapter</param>
        /// <returns>Un DataTable con los registros obtenidos</returns>
        public DataTable Consultar(SqlDataAdapter adapter)
        {
            if (conexion == null) conexion = new SqlConnection(cadena);
            if (conexion.State == ConnectionState.Closed) conexion.Open();
            
            adapter.SelectCommand.Connection = conexion;
            var resultado = new DataTable();
            adapter.Fill(resultado);
            conexion.Close();
            return resultado;
        }


    }
}
