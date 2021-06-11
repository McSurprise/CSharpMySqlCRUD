using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlCRUD.CapaNegocio;

namespace MySqlCRUD
{
    public partial class Form1 : Form
    {


        Libro libroo = new Libro();
        Autor autorr = new Autor();
        Prestamo prestamoo = new Prestamo();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string codLibro = txtCod.Text;
            string titulo = txtTit.Text;
            string editorial = txtEdi.Text;
            bool CodError = libroo.Agregar(codLibro, titulo, editorial);
            Clear();
            dgvBook.DataSource = libroo.Listar();
            raea.Text = CodError.ToString();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            ClearAutor();
            ClearPrestamo();
            dgvBook.DataSource = libroo.Listar();
            dataGridView2.DataSource = prestamoo.ListarPrestamo();
            dataGridView1.DataSource = autorr.ListarAutor();
        }

        void Clear()
        {
            txtCod.Text = txtTit.Text = txtEdi.Text = txtSearch.Text = "";
            btnGuardar.Text = "Guardar";
            btnDelete.Enabled = false;
        }

        private void dgvBook_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBook.CurrentRow.Index != -1)
            {
                txtCod.Text = dgvBook.CurrentRow.Cells[0].Value.ToString();
                txtTit.Text = dgvBook.CurrentRow.Cells[1].Value.ToString();
                txtEdi.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
                btnGuardar.Text = "Actualizar";
                btnDelete.Enabled = Enabled;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string texto = txtSearch.Text;
            dgvBook.DataSource = libroo.Buscar(texto);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string codLibro = txtCod.Text;
            bool codError = libroo.Eliminar(codLibro);
            Clear();
            dgvBook.DataSource = libroo.Listar();
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvBook.DataSource = libroo.Listar();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void raea_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }




        /// //////////////////////////////////////// PRESTAMO
        /// 

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBook.CurrentRow.Index != -1)
            {
                textFecPrestamo.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                textCodLibroPrestamo.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                textCodAutorPrestamo.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                btnGuardarPrestamo.Text = "Actualizar";
                btnEliminarPrestamo.Enabled = Enabled;
            }
        }
        private void btnGuardarPrestamo_Click(object sender, EventArgs e)
        {
            string codLibro = textFecPrestamo.Text;
            string titulo = textCodLibroPrestamo.Text;
            string editorial = textCodAutorPrestamo.Text;
            bool CodError = prestamoo.AgregarPrestamo(codLibro, titulo, editorial);
            ClearPrestamo();
            dataGridView2.DataSource = prestamoo.ListarPrestamo();
            raea.Text = CodError.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.DataSource = prestamoo.ListarPrestamo();
        }

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            string fechaPrestamo = textFecPrestamo.Text;
            bool codError = prestamoo.EliminarPrestamo(fechaPrestamo);
            ClearPrestamo();
            dataGridView2.DataSource = prestamoo.ListarPrestamo();
        }

        private void btnCancelarPrestamo_Click(object sender, EventArgs e)
        {
            ClearPrestamo();
        }

        private void btnBuscarPrestamo_Click(object sender, EventArgs e)
        {
            string texto = textBuscarPrestamo.Text;
            dataGridView2.DataSource = prestamoo.BuscarPrestamo(texto);
        }

        void ClearPrestamo()
        {
            textCodLibroPrestamo.Text = textFecPrestamo.Text = textCodAutorPrestamo.Text = textBuscarPrestamo.Text = "";
            btnGuardarPrestamo.Text = "Guardar";
            btnEliminarPrestamo.Enabled = false;
        }

        /// <summary>
        /// ////////////////////////////////////////  AUTOR

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dgvBook.CurrentRow.Index != -1)
            {
                textCodAutor.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textNomAutor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textApeAutor.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textNacAutor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                btnGuardarAutor.Text = "Actualizar";
                btnEliminarAutor.Enabled = Enabled;
            }
        }
        private void btnGuardarAutor_Click(object sender, EventArgs e)
        {
            string codAutor = textCodAutor.Text;
            string nombres = textNomAutor.Text;
            string apellidos = textApeAutor.Text;
            string nacionalidad = textNacAutor.Text;
            bool CodError = autorr.AgregarAutor(codAutor, apellidos, nombres, nacionalidad);
            ClearAutor();
            dataGridView1.DataSource = autorr.ListarAutor();
        }

        private void btnEliminarAutor_Click(object sender, EventArgs e)
        {
            string codAutor = textCodAutor.Text;
            bool codError = autorr.EliminarAutor(codAutor);
            ClearAutor();
            dataGridView1.DataSource = autorr.ListarAutor ();
        }

        private void btnCancelarAutor_Click(object sender, EventArgs e)
        {
            ClearAutor();
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            string texto = textBuscarAutor.Text;
            dataGridView1.DataSource = autorr.BuscarAutor(texto);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.DataSource = prestamoo.ListarPrestamo();
        }
        void ClearAutor()
        {
            textCodAutor.Text = textNomAutor.Text = textApeAutor.Text = textNacAutor.Text = textBuscarAutor.Text = "";
            btnGuardarAutor.Text = "Guardar";
            btnEliminarAutor.Enabled = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
