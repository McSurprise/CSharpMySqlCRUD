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
    class Libro : ILibro
    {

        string connectionString = @"Server=localhost;Database=bdbiblioteca2;Uid=root;Pwd=;";
        public bool Actualizar(string codLibro, string titulo, string editorial)
        {
            throw new NotImplementedException();
        }

        public bool Agregar(string codLibro, string titulo, string editorial)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("PAAniadirOEditar", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_CodLibro", codLibro);
                mySqlCmd.Parameters.AddWithValue("_Titulo", titulo);
                mySqlCmd.Parameters.AddWithValue("_Editorial", editorial);
                mySqlCmd.ExecuteNonQuery();
                Listar();
                return true;
            }
        }

        public DataTable Buscar(string texto)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("PABuscar", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_ValorDeBusqueda", texto);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                return dtblBook;
            }
        }

        public bool Eliminar(string codLibro)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("PAEliminar", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_CodLibro", codLibro);
                mySqlCmd.ExecuteNonQuery();
                Listar();
                return true;
            }
        }

        public DataTable Listar()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("PAListar", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                //dgvBook.DataSource = dtblBook;
                //dgvBook.Columns[0].Visible = false;
                return dtblBook;
            }
        }
        

    }
}

