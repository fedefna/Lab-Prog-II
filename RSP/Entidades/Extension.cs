using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        public static void Guardar(this Aeropuerto<IAvion> emisor)
        {
            string dbName = "final-20190711";
            string connectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=" + dbName + "; Integrated Security=True;";
            SqlCommand comando;
            SqlConnection conexion;

            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            try
            {
                string insert = "INSERT INTO Bitacora (entrada,alumno) VALUES('" + DateTime.Now + "','Federico Alaniz')";
                comando.CommandText = insert;
                comando.Connection.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                comando.Connection.Close();
            }
        }
    }
}
