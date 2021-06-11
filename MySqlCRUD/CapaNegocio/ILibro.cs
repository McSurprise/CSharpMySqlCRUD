using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MySqlCRUD.CapaNegocio
{
    interface ILibro
    {
        DataTable Listar();
        bool Agregar(string codLibro, string titulo, string editorial);
        bool Eliminar(string codLibro);
        bool Actualizar(string codLibro, string titulo, string editorial);
        DataTable Buscar(string texto);

    }
}
