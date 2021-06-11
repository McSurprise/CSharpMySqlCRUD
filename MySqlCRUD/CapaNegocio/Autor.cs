using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace MySqlCRUD.CapaNegocio
{
    class Autor : IAutor
    {
        string connectionString = @"Server=localhost;Database=bdbiblioteca2;Uid=root;Pwd=;";
        public bool ActualizarAutor(string codAutor, string Apellidos, string Nombres, string Nacionalidad)
        {
            throw new NotImplementedException();
        }

        public bool AgregarAutor(string CodAutor, string Apellidos, string Nombres, string Nacionalidad)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("PAAniadirOEditarAutor", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_CodAutor", CodAutor);
                mySqlCmd.Parameters.AddWithValue("_Apellidos", Apellidos);
                mySqlCmd.Parameters.AddWithValue("_Nombres", Nombres);
                mySqlCmd.Parameters.AddWithValue("_Nacionalidad", Nacionalidad);
                mySqlCmd.ExecuteNonQuery();
                ListarAutor();
                return true;
            }
        }

        public DataTable BuscarAutor(string texto)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("PABuscarAutor", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_ValorDeBusqueda", texto);
                DataTable dtblAutor = new DataTable();
                sqlDa.Fill(dtblAutor);
                return dtblAutor;
            }
        }

        public bool EliminarAutor(string CodAutor)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("PAEliminarAutor", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_CodAutor", CodAutor);
                mySqlCmd.ExecuteNonQuery();
                ListarAutor();
                return true;
            }
        }

        public DataTable ListarAutor()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("PAListarAutor", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblAutor = new DataTable();
                sqlDa.Fill(dtblAutor);
                //dgvBook.DataSource = dtblBook;
                //dgvBook.Columns[0].Visible = false;
                return dtblAutor;
            }
        }
    }
}
