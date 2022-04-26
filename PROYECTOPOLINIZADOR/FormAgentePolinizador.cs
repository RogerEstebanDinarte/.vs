using System;
using System.Windows.Forms;
using PROYECTOPOLINIZADOR.Classes;

namespace PROYECTOPOLINIZADOR
{
    public partial class FormAgentePolinizador : Form
    {
        public FormAgentePolinizador()
        {
            InitializeComponent();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {  
            try
            {
                ClsAgente vAgente = new ClsAgente(Int32.Parse(txtIdAgente.Text), txtNombre.Text, txtTipo.Text, txtSubtipo.Text);
                vAgente.MantenimientoAgentes(vAgente, "I");
                LimpiarCampos();
                ListaAgentes();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ListaAgentes();
            LimpiarCampos();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ClsAgente vAgente = new ClsAgente(Int32.Parse(txtIdAgente.Text), txtNombre.Text, txtTipo.Text, txtSubtipo.Text);
                vAgente.MantenimientoAgentes(vAgente, "E");
                LimpiarCampos();
                ListaAgentes();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsAgente vAgente = new ClsAgente(Int32.Parse(txtIdAgente.Text), txtNombre.Text, txtTipo.Text, txtSubtipo.Text);
                vAgente.MantenimientoAgentes(vAgente, "M");
                LimpiarCampos();
                ListaAgentes();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtIdAgente.Text = "";
            txtNombre.Text = "";
            txtTipo.Text = "";
            txtSubtipo.Text = "";
        }

        public void ListaAgentes()
        {
            ClsAgente vAgente = new ClsAgente();
            tblMostrar.DataSource = vAgente.ListaAgentes(vAgente, "S");

        }

        private void FormAgentePolinizador_Load(object sender, EventArgs e)
        {

        }
    }
    
}
