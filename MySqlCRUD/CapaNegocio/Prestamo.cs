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
    class Prestamo : IPrestamo
    {
        string connectionString = @"Server=localhost;Database=bdbiblioteca2;Uid=root;Pwd=; convert zero datetime=True;";
        public bool ActualizarPrestamo(string FechaPrestamo, string CodLibro, string CodAutor)
        {
            throw new NotImplementedException();
        }

        public bool AgregarPrestamo(string FechaPrestamo, string CodAutor,string CodLibro)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("PAAniadirOEditarPrestamo", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_FechaPrestamo", FechaPrestamo);
                mySqlCmd.Parameters.AddWithValue("_CodAutor", CodAutor);
                mySqlCmd.Parameters.AddWithValue("_CodLibro", CodLibro);
                mySqlCmd.ExecuteNonQuery();
                ListarPrestamo();
                return true;
            }
        }

        public DataTable BuscarPrestamo(string texto)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("PABuscarPrestamo", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_ValorDeBusqueda", texto);
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                return dtblBook;
            }
        }

        public bool EliminarPrestamo(string FechaPrestamo)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("PAEliminarPrestamo", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_FechaPrestamo", FechaPrestamo);
                mySqlCmd.ExecuteNonQuery();
                ListarPrestamo();
                return true;
            }
        }

        public DataTable ListarPrestamo()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("PAListarPrestamo", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblPrestamo= new DataTable();
                sqlDa.Fill(dtblPrestamo);
                //dgvBook.DataSource = dtblBook;
                //dgvBook.Columns[0].Visible = false;
                return dtblPrestamo;
            }
        }
    }
}
