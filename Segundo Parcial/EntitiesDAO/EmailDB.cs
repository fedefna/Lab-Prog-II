using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;
using EntitiesDAO;

namespace Persistencia
{
    public class EmailDB : IData<List<EmisorDeEmails>>
    {
        private string connectionString;
        public static SqlCommand comando;
        public static SqlConnection conexion;   

        /// <summary>
        /// Seteo los valores de conexion
        /// </summary>
        public EmailDB()
        {
            string dbName = "SP_2019";
            connectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=" + dbName + "; Integrated Security=True;";

            try
            {
                conexion = new SqlConnection(connectionString);
                comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// /// Metodo que realiza un insert en la base de datos
        /// </summary>
        /// <param name="emisor"></param>
        /// <returns></returns>
        public void Guardar(Emisor emisor)
        {
            try
            {
                EmisorDeEmails emi = (EmisorDeEmails)emisor;
                string insert = "INSERT INTO Emails2 (Mensaje,Producto,Email) VALUES('"+emi.Mensaje+"','"+emi.Producto+"','"+emi.Email+"')";
                comando.CommandText = insert;
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Lee la tabla indicada de la base y devuelve una lista con los registros que tenga la tabla.
        /// </summary>
        /// <returns></returns>
        public List<EmisorDeEmails> Leer()
        {
            List<EmisorDeEmails> lstEmisores= new List<EmisorDeEmails>();
            EmisorDeEmails emisor;

            string consulta = String.Format("Select * from Emails2");

            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    string mensaje = oDr["Mensaje"].ToString();
                    EProducto producto = (EProducto)Enum.Parse(typeof(EProducto),oDr["Producto"].ToString());
                    //EProducto producto = (EProducto)oDr["Producto"];
                    string email = oDr["Email"].ToString();
                    emisor = new EmisorDeEmails(mensaje, producto, email);
                    lstEmisores.Add(emisor);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }

            return lstEmisores;
        }
    }
}
