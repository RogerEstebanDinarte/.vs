
namespace PROYECTOPOLINIZADOR
{
    partial class FormFlores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFlores));
            this.tblMostrar = new System.Windows.Forms.DataGridView();
            this.tbFloresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdProcesosPolinizadoresDataSet = new PROYECTOPOLINIZADOR.BdProcesosPolinizadoresDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddFoto = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdAgente = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdEspecie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFloresTableAdapter = new PROYECTOPOLINIZADOR.BdProcesosPolinizadoresDataSetTableAdapters.TbFloresTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEspecieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAgenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotografiaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFloresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdProcesosPolinizadoresDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMostrar
            // 
            this.tblMostrar.AllowUserToAddRows = false;
            this.tblMostrar.AutoGenerateColumns = false;
            this.tblMostrar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tblMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.idEspecieDataGridViewTextBoxColumn,
            this.idAgenteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fotografiaDataGridViewImageColumn});
            this.tblMostrar.DataSource = this.tbFloresBindingSource;
            this.tblMostrar.GridColor = System.Drawing.SystemColors.Control;
            this.tblMostrar.Location = new System.Drawing.Point(61, 369);
            this.tblMostrar.Name = "tblMostrar";
            this.tblMostrar.RowHeadersWidth = 51;
            this.tblMostrar.Size = new System.Drawing.Size(651, 187);
            this.tblMostrar.TabIndex = 16;
            this.tblMostrar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblMostrar_CellClick);
            this.tblMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblMostrar_CellContentClick);
            // 
            // tbFloresBindingSource
            // 
            this.tbFloresBindingSource.DataMember = "TbFlores";
            this.tbFloresBindingSource.DataSource = this.bdProcesosPolinizadoresDataSet;
            // 
            // bdProcesosPolinizadoresDataSet
            // 
            this.bdProcesosPolinizadoresDataSet.DataSetName = "BdProcesosPolinizadoresDataSet";
            this.bdProcesosPolinizadoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnMostrar);
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.btnModificar);
            this.panel3.Location = new System.Drawing.Point(24, 278);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 85);
            this.panel3.TabIndex = 19;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(529, 25);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(118, 43);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.Black;
            this.btnMostrar.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrar.Image")));
            this.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.Location = new System.Drawing.Point(357, 25);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(138, 43);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(31, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(127, 43);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(189, 25);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 43);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAddFoto);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.pbxImagen);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtIdAgente);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtIdEspecie);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(24, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 216);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAddFoto
            // 
            this.btnAddFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFoto.Location = new System.Drawing.Point(537, 59);
            this.btnAddFoto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddFoto.Name = "btnAddFoto";
            this.btnAddFoto.Size = new System.Drawing.Size(92, 23);
            this.btnAddFoto.TabIndex = 17;
            this.btnAddFoto.Text = "Agregar Foto";
            this.btnAddFoto.UseVisualStyleBackColor = true;
            this.btnAddFoto.Click += new System.EventHandler(this.btnAddFoto_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(316, 65);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(156, 69);
            this.txtDescripcion.TabIndex = 16;
            this.txtDescripcion.Text = "";
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(537, 92);
            this.pbxImagen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(135, 96);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 15;
            this.pbxImagen.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fotografia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Id Agente:";
            // 
            // txtIdAgente
            // 
            this.txtIdAgente.Location = new System.Drawing.Point(113, 118);
            this.txtIdAgente.Name = "txtIdAgente";
            this.txtIdAgente.Size = new System.Drawing.Size(141, 20);
            this.txtIdAgente.TabIndex = 12;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(113, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(141, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(313, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 168);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(141, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Especie:";
            // 
            // txtIdEspecie
            // 
            this.txtIdEspecie.Location = new System.Drawing.Point(113, 65);
            this.txtIdEspecie.Name = "txtIdEspecie";
            this.txtIdEspecie.Size = new System.Drawing.Size(141, 20);
            this.txtIdEspecie.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codigo:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(24, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 36);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Flores";
            // 
            // tbFloresTableAdapter
            // 
            this.tbFloresTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // idEspecieDataGridViewTextBoxColumn
            // 
            this.idEspecieDataGridViewTextBoxColumn.DataPropertyName = "IdEspecie";
            this.idEspecieDataGridViewTextBoxColumn.HeaderText = "IdEspecie";
            this.idEspecieDataGridViewTextBoxColumn.Name = "idEspecieDataGridViewTextBoxColumn";
            // 
            // idAgenteDataGridViewTextBoxColumn
            // 
            this.idAgenteDataGridViewTextBoxColumn.DataPropertyName = "IdAgente";
            this.idAgenteDataGridViewTextBoxColumn.HeaderText = "IdAgente";
            this.idAgenteDataGridViewTextBoxColumn.Name = "idAgenteDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // fotografiaDataGridViewImageColumn
            // 
            this.fotografiaDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fotografiaDataGridViewImageColumn.DataPropertyName = "Fotografia";
            this.fotografiaDataGridViewImageColumn.FillWeight = 400F;
            this.fotografiaDataGridViewImageColumn.HeaderText = "Fotografia";
            this.fotografiaDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.fotografiaDataGridViewImageColumn.MinimumWidth = 7;
            this.fotografiaDataGridViewImageColumn.Name = "fotografiaDataGridViewImageColumn";
            this.fotografiaDataGridViewImageColumn.ReadOnly = true;
            this.fotografiaDataGridViewImageColumn.Width = 60;
            // 
            // FormFlores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 575);
            this.Controls.Add(this.tblMostrar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormFlores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flores";
            this.Load += new System.EventHandler(this.FormFlores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFloresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdProcesosPolinizadoresDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblMostrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdAgente;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdEspecie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button btnAddFoto;
        private BdProcesosPolinizadoresDataSet bdProcesosPolinizadoresDataSet;
        private System.Windows.Forms.BindingSource tbFloresBindingSource;
        private BdProcesosPolinizadoresDataSetTableAdapters.TbFloresTableAdapter tbFloresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAgenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotografiaDataGridViewImageColumn;
    }
}