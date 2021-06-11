namespace MySqlCRUD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdi = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.raea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancelarAutor = new System.Windows.Forms.Button();
            this.btnEliminarAutor = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.btnGuardarAutor = new System.Windows.Forms.Button();
            this.textApeAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNomAutor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBuscarAutor = new System.Windows.Forms.TextBox();
            this.textCodAutor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnCancelarPrestamo = new System.Windows.Forms.Button();
            this.btnEliminarPrestamo = new System.Windows.Forms.Button();
            this.btnBuscarPrestamo = new System.Windows.Forms.Button();
            this.btnGuardarPrestamo = new System.Windows.Forms.Button();
            this.textCodAutorPrestamo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textCodLibroPrestamo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBuscarPrestamo = new System.Windows.Forms.TextBox();
            this.textFecPrestamo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textNacAutor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(162, 96);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(217, 34);
            this.txtCod.TabIndex = 1;
            this.txtCod.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(27, 221);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 37);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(395, 96);
            this.dgvBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.Size = new System.Drawing.Size(410, 162);
            this.dgvBook.TabIndex = 3;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            this.dgvBook.DoubleClick += new System.EventHandler(this.dgvBook_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "TITULO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTit
            // 
            this.txtTit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTit.Location = new System.Drawing.Point(162, 135);
            this.txtTit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTit.Name = "txtTit";
            this.txtTit.Size = new System.Drawing.Size(217, 34);
            this.txtTit.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "EDITORIAL:";
            // 
            // txtEdi
            // 
            this.txtEdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdi.Location = new System.Drawing.Point(162, 174);
            this.txtEdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEdi.Multiline = true;
            this.txtEdi.Name = "txtEdi";
            this.txtEdi.Size = new System.Drawing.Size(217, 28);
            this.txtEdi.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(44)))), ((int)(((byte)(25)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(147, 221);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(121)))), ((int)(((byte)(168)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(267, 221);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(395, 52);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(266, 34);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(678, 52);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // raea
            // 
            this.raea.AutoSize = true;
            this.raea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raea.Location = new System.Drawing.Point(358, 9);
            this.raea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.raea.Name = "raea";
            this.raea.Size = new System.Drawing.Size(90, 28);
            this.raea.TabIndex = 4;
            this.raea.Text = "CODIGO:";
            this.raea.Click += new System.EventHandler(this.raea_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "AUTOR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 363);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(410, 162);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // btnCancelarAutor
            // 
            this.btnCancelarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(121)))), ((int)(((byte)(168)))));
            this.btnCancelarAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAutor.ForeColor = System.Drawing.Color.White;
            this.btnCancelarAutor.Location = new System.Drawing.Point(267, 488);
            this.btnCancelarAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarAutor.Name = "btnCancelarAutor";
            this.btnCancelarAutor.Size = new System.Drawing.Size(112, 37);
            this.btnCancelarAutor.TabIndex = 12;
            this.btnCancelarAutor.Text = "Cancelar";
            this.btnCancelarAutor.UseVisualStyleBackColor = false;
            this.btnCancelarAutor.Click += new System.EventHandler(this.btnCancelarAutor_Click);
            // 
            // btnEliminarAutor
            // 
            this.btnEliminarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(44)))), ((int)(((byte)(25)))));
            this.btnEliminarAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAutor.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAutor.Location = new System.Drawing.Point(147, 488);
            this.btnEliminarAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarAutor.Name = "btnEliminarAutor";
            this.btnEliminarAutor.Size = new System.Drawing.Size(112, 37);
            this.btnEliminarAutor.TabIndex = 13;
            this.btnEliminarAutor.Text = "Eliminar";
            this.btnEliminarAutor.UseVisualStyleBackColor = false;
            this.btnEliminarAutor.Click += new System.EventHandler(this.btnEliminarAutor_Click);
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.btnBuscarAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAutor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAutor.Location = new System.Drawing.Point(678, 319);
            this.btnBuscarAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(112, 37);
            this.btnBuscarAutor.TabIndex = 14;
            this.btnBuscarAutor.Text = "BUSCAR";
            this.btnBuscarAutor.UseVisualStyleBackColor = false;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // btnGuardarAutor
            // 
            this.btnGuardarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.btnGuardarAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAutor.ForeColor = System.Drawing.Color.White;
            this.btnGuardarAutor.Location = new System.Drawing.Point(27, 488);
            this.btnGuardarAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarAutor.Name = "btnGuardarAutor";
            this.btnGuardarAutor.Size = new System.Drawing.Size(112, 37);
            this.btnGuardarAutor.TabIndex = 15;
            this.btnGuardarAutor.Text = "Guardar";
            this.btnGuardarAutor.UseVisualStyleBackColor = false;
            this.btnGuardarAutor.Click += new System.EventHandler(this.btnGuardarAutor_Click);
            // 
            // textApeAutor
            // 
            this.textApeAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApeAutor.Location = new System.Drawing.Point(162, 412);
            this.textApeAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textApeAutor.Multiline = true;
            this.textApeAutor.Name = "textApeAutor";
            this.textApeAutor.Size = new System.Drawing.Size(217, 28);
            this.textApeAutor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 412);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "APELLIDOS:";
            // 
            // textNomAutor
            // 
            this.textNomAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomAutor.Location = new System.Drawing.Point(162, 368);
            this.textNomAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNomAutor.Name = "textNomAutor";
            this.textNomAutor.Size = new System.Drawing.Size(217, 34);
            this.textNomAutor.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 371);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "NOMBRES:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBuscarAutor
            // 
            this.textBuscarAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscarAutor.Location = new System.Drawing.Point(395, 319);
            this.textBuscarAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBuscarAutor.Name = "textBuscarAutor";
            this.textBuscarAutor.Size = new System.Drawing.Size(266, 34);
            this.textBuscarAutor.TabIndex = 10;
            // 
            // textCodAutor
            // 
            this.textCodAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodAutor.Location = new System.Drawing.Point(162, 329);
            this.textCodAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCodAutor.Name = "textCodAutor";
            this.textCodAutor.Size = new System.Drawing.Size(217, 34);
            this.textCodAutor.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 332);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 28);
            this.label7.TabIndex = 7;
            this.label7.Text = "CODIGO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(358, 542);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "PRESTAMO";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(395, 626);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(410, 162);
            this.dataGridView2.TabIndex = 29;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // btnCancelarPrestamo
            // 
            this.btnCancelarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(121)))), ((int)(((byte)(168)))));
            this.btnCancelarPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnCancelarPrestamo.Location = new System.Drawing.Point(267, 751);
            this.btnCancelarPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarPrestamo.Name = "btnCancelarPrestamo";
            this.btnCancelarPrestamo.Size = new System.Drawing.Size(112, 37);
            this.btnCancelarPrestamo.TabIndex = 25;
            this.btnCancelarPrestamo.Text = "Cancelar";
            this.btnCancelarPrestamo.UseVisualStyleBackColor = false;
            this.btnCancelarPrestamo.Click += new System.EventHandler(this.btnCancelarPrestamo_Click);
            // 
            // btnEliminarPrestamo
            // 
            this.btnEliminarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(44)))), ((int)(((byte)(25)))));
            this.btnEliminarPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPrestamo.Location = new System.Drawing.Point(147, 751);
            this.btnEliminarPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            this.btnEliminarPrestamo.Size = new System.Drawing.Size(112, 37);
            this.btnEliminarPrestamo.TabIndex = 26;
            this.btnEliminarPrestamo.Text = "Eliminar";
            this.btnEliminarPrestamo.UseVisualStyleBackColor = false;
            this.btnEliminarPrestamo.Click += new System.EventHandler(this.btnEliminarPrestamo_Click);
            // 
            // btnBuscarPrestamo
            // 
            this.btnBuscarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.btnBuscarPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarPrestamo.Location = new System.Drawing.Point(678, 582);
            this.btnBuscarPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarPrestamo.Name = "btnBuscarPrestamo";
            this.btnBuscarPrestamo.Size = new System.Drawing.Size(112, 37);
            this.btnBuscarPrestamo.TabIndex = 27;
            this.btnBuscarPrestamo.Text = "BUSCAR";
            this.btnBuscarPrestamo.UseVisualStyleBackColor = false;
            this.btnBuscarPrestamo.Click += new System.EventHandler(this.btnBuscarPrestamo_Click);
            // 
            // btnGuardarPrestamo
            // 
            this.btnGuardarPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(110)))), ((int)(((byte)(181)))));
            this.btnGuardarPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPrestamo.Location = new System.Drawing.Point(27, 751);
            this.btnGuardarPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarPrestamo.Name = "btnGuardarPrestamo";
            this.btnGuardarPrestamo.Size = new System.Drawing.Size(112, 37);
            this.btnGuardarPrestamo.TabIndex = 28;
            this.btnGuardarPrestamo.Text = "Guardar";
            this.btnGuardarPrestamo.UseVisualStyleBackColor = false;
            this.btnGuardarPrestamo.Click += new System.EventHandler(this.btnGuardarPrestamo_Click);
            // 
            // textCodAutorPrestamo
            // 
            this.textCodAutorPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodAutorPrestamo.Location = new System.Drawing.Point(162, 704);
            this.textCodAutorPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCodAutorPrestamo.Multiline = true;
            this.textCodAutorPrestamo.Name = "textCodAutorPrestamo";
            this.textCodAutorPrestamo.Size = new System.Drawing.Size(217, 28);
            this.textCodAutorPrestamo.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 704);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "C. LIBRO:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textCodLibroPrestamo
            // 
            this.textCodLibroPrestamo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textCodLibroPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodLibroPrestamo.Location = new System.Drawing.Point(162, 665);
            this.textCodLibroPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textCodLibroPrestamo.Name = "textCodLibroPrestamo";
            this.textCodLibroPrestamo.Size = new System.Drawing.Size(217, 34);
            this.textCodLibroPrestamo.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 668);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 28);
            this.label10.TabIndex = 19;
            this.label10.Text = "C. AUTOR:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBuscarPrestamo
            // 
            this.textBuscarPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscarPrestamo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBuscarPrestamo.Location = new System.Drawing.Point(395, 582);
            this.textBuscarPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBuscarPrestamo.Name = "textBuscarPrestamo";
            this.textBuscarPrestamo.Size = new System.Drawing.Size(266, 34);
            this.textBuscarPrestamo.TabIndex = 23;
            // 
            // textFecPrestamo
            // 
            this.textFecPrestamo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFecPrestamo.Location = new System.Drawing.Point(162, 626);
            this.textFecPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textFecPrestamo.Name = "textFecPrestamo";
            this.textFecPrestamo.Size = new System.Drawing.Size(217, 34);
            this.textFecPrestamo.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(63, 629);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 28);
            this.label11.TabIndex = 20;
            this.label11.Text = "FECHA:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textNacAutor
            // 
            this.textNacAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNacAutor.Location = new System.Drawing.Point(162, 450);
            this.textNacAutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textNacAutor.Multiline = true;
            this.textNacAutor.Name = "textNacAutor";
            this.textNacAutor.Size = new System.Drawing.Size(217, 28);
            this.textNacAutor.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 450);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 28);
            this.label12.TabIndex = 31;
            this.label12.Text = "NACIONALIDAD:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 844);
            this.Controls.Add(this.textNacAutor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnCancelarPrestamo);
            this.Controls.Add(this.btnEliminarPrestamo);
            this.Controls.Add(this.btnBuscarPrestamo);
            this.Controls.Add(this.btnGuardarPrestamo);
            this.Controls.Add(this.textCodAutorPrestamo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textCodLibroPrestamo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBuscarPrestamo);
            this.Controls.Add(this.textFecPrestamo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelarAutor);
            this.Controls.Add(this.btnEliminarAutor);
            this.Controls.Add(this.btnBuscarAutor);
            this.Controls.Add(this.btnGuardarAutor);
            this.Controls.Add(this.textApeAutor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNomAutor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBuscarAutor);
            this.Controls.Add(this.textCodAutor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.raea);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "MySql CRUD APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdi;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label raea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancelarAutor;
        private System.Windows.Forms.Button btnEliminarAutor;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button btnGuardarAutor;
        private System.Windows.Forms.TextBox textApeAutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNomAutor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBuscarAutor;
        private System.Windows.Forms.TextBox textCodAutor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnCancelarPrestamo;
        private System.Windows.Forms.Button btnEliminarPrestamo;
        private System.Windows.Forms.Button btnBuscarPrestamo;
        private System.Windows.Forms.Button btnGuardarPrestamo;
        private System.Windows.Forms.TextBox textCodAutorPrestamo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textCodLibroPrestamo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBuscarPrestamo;
        private System.Windows.Forms.TextBox textFecPrestamo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textNacAutor;
        private System.Windows.Forms.Label label12;
    }
}

