using System;
using System.Windows.Forms;
using PROYECTOPOLINIZADOR.Classes;

namespace PROYECTOPOLINIZADOR
{
    public partial class FormEspecies : Form
    {
        public FormEspecies()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsEspecies vEspecie = new ClsEspecies(Int32.Parse(txtIdEspecie.Text), txtNombre.Text, 
                    txtEpocaFloracion.Text, txtEstacion.Text, txtSuelo.Text, Int32.Parse(txtExposicion.Text));
                vEspecie.MantenimientoAgentes(vEspecie, "I");
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
            txtIdEspecie.Text = "";
            txtNombre.Text = "";
            txtEpocaFloracion.Text = "";
            txtEstacion.Text = "";
            txtSuelo.Text = "";
            txtExposicion.Text = "";
        }

        public void ListaAgentes()
        {
            ClsEspecies vEspecie = new ClsEspecies();
            tblMostrar.DataSource = vEspecie.ListaEspecies(vEspecie, "S");

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                ClsEspecies vEspecie = new ClsEspecies(Int32.Parse(txtIdEspecie.Text), txtNombre.Text,
                     txtEpocaFloracion.Text, txtEstacion.Text, txtSuelo.Text, Int32.Parse(txtExposicion.Text));
                vEspecie.MantenimientoAgentes(vEspecie, "M");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                txtExposicion.Text = "0";
                ClsEspecies vEspecie = new ClsEspecies(Int32.Parse(txtIdEspecie.Text), txtNombre.Text,
                    txtEpocaFloracion.Text, txtEstacion.Text, txtSuelo.Text, Int32.Parse(txtExposicion.Text));
                vEspecie.MantenimientoAgentes(vEspecie, "E");
                LimpiarCampos();
                ListaAgentes();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
