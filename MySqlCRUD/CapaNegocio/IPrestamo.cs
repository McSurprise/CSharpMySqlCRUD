using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MySqlCRUD.CapaNegocio
{
    interface IPrestamo
    {
        DataTable ListarPrestamo();
        bool AgregarPrestamo(string FechaPrestamo, string CodAutor, string CodLibro);
        bool EliminarPrestamo(string FechaPrestamo);
        bool ActualizarPrestamo(string FechaPrestamo, string CodAutor, string CodLibro);
        DataTable BuscarPrestamo(string texto);
    }
}
