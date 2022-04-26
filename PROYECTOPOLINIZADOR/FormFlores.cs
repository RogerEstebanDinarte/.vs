using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PROYECTOPOLINIZADOR.Classes;

namespace PROYECTOPOLINIZADOR
{
    public partial class FormFlores : Form
    {
        public FormFlores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Agregar Imagen
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pbxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                ClsFlores vFlores = new ClsFlores(Int32.Parse(txtCodigo.Text), Int32.Parse(txtIdEspecie.Text),
                     Int32.Parse(txtIdAgente.Text), txtNombre.Text, txtDescripcion.Text, ms.GetBuffer());
                vFlores.MantenimientoFlores(vFlores, "I");
                LimpiarCampos();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void LimpiarCampos()
        {
            txtIdEspecie.Text = "";
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtIdAgente.Text = "";
            pbxImagen.Text = "";
        }

        /*public void ListFlores()
        {
            ClsFlores vFlores = new ClsFlores();
            tblMostrar.DataSource = vFlores.ListaFlores(vFlores, "S");

        }*/


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
                // TODO: esta línea de código carga datos en la tabla 'bdProcesosPolinizadoresDataSet.TbFlores' Puede moverla o quitarla según sea necesario.
                this.tbFloresTableAdapter.Fill(this.bdProcesosPolinizadoresDataSet.TbFlores);

            }
            catch (Exception Ex) { 
                MessageBox.Show(Ex.Message);
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                MemoryStream ms = new MemoryStream();
                pbxImagen.Image.Save(ms, pbxImagen.Image.RawFormat);
                byte[] img = ms.ToArray();
                tblMostrar.Rows.Add(txtCodigo.Text, img);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog winFile = new OpenFileDialog();
            winFile.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            DialogResult rs = winFile.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pbxImagen.Image = Image.FromFile(winFile.FileName);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //Modificar Imagen
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pbxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                ClsFlores vFlores = new ClsFlores(Int32.Parse(txtCodigo.Text), Int32.Parse(txtIdEspecie.Text),
                     Int32.Parse(txtIdAgente.Text), txtNombre.Text, txtDescripcion.Text, ms.GetBuffer());
                vFlores.MantenimientoFlores(vFlores, "M");
                LimpiarCampos();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                ClsFlores vFlores = new ClsFlores(Int32.Parse(txtCodigo.Text));
                
                vFlores.MantenimientoFlores(vFlores, "E");
                LimpiarCampos();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void FormFlores_Load(object sender, EventArgs e)
        {
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tblMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void tblMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigo.Text = tblMostrar.SelectedRows[0].Cells[0].Value.ToString();
                txtIdEspecie.Text = tblMostrar.SelectedRows[0].Cells[1].Value.ToString();
                txtIdAgente.Text = tblMostrar.SelectedRows[0].Cells[2].Value.ToString();
                txtNombre.Text = tblMostrar.SelectedRows[0].Cells[3].Value.ToString();
                txtDescripcion.Text = tblMostrar.SelectedRows[0].Cells[4].Value.ToString();
                

            }
            catch (Exception Ex) { 
                MessageBox.Show(Ex.Message);    
            
            }
        }
    }
}
