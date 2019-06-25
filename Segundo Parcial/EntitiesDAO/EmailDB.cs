using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Entities;
using EntitiesDAO;

namespace Persistencia
{
    public class EmailDB : IData<T>
    {
        private readonly string connectionString;

        /// <summary>
        /// Asigna un valor al connectionString
        /// </summary>
        public EmailDB()
        {
            string dbName = "SP_2019";
            connectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=" + dbName + "; Integrated Security=True;";
        }

        public void Guardar(Emisor emisor, T datos)
        {
            
            try
            {
                SqlCommand insertCommand = new SqlCommand();
                insertCommand.CommandType = System.Data.CommandType.Text;
                string insertText = "INSERT INTO dbo.Emails2 (Mensaje,Producto,Email) VALUES('"+emisor.Mensaje+"','"+emisor.Producto+"','"+emisor.Email+"')";
                insertCommand.CommandText = insertText;
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("Db insertion successfull");
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed on db insertion");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("------------------------------");
            }
        }

        public T Leer<T>()
        {
            try
            {
                // LE PASO LA INSTRUCCION SQL
                this.comando.CommandText = "SELECT patente,tipo FROM " + tabla;
                // ABRO LA CONEXION A LA BD
                this.conexion.Open();
                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = this.comando.ExecuteReader();
                // MIENTRAS TENGA REGISTROS...
                while (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    datos.Enqueue(new Patente(oDr["patente"].ToString(), (Patente.Tipo)Enum.Parse(typeof(Patente.Tipo), oDr["tipo"].ToString())));
                }

                //CIERRO EL DATAREADER
                oDr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed on db insertion");
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                dataReader.Close();
                Console.WriteLine("------------------------------");
            }
        }
    }
}
