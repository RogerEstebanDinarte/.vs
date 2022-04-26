using System;
using System.Windows.Forms;

namespace PROYECTOPOLINIZADOR
{
    public partial class FormMenuMain : Form
    {
        public FormMenuMain()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(-1);
        }

        private void btnAgente_Click(object sender, EventArgs e)
        {
            FormAgentePolinizador winAgente = new FormAgentePolinizador();
            winAgente.Show();
            
        }

        private void btnEspecies_Click(object sender, EventArgs e)
        {
            FormEspecies winEspecies = new FormEspecies();
            winEspecies.Show();
        }

        private void btnFlores_Click(object sender, EventArgs e)
        {
            FormFlores winFlores = new FormFlores();
            winFlores.Show();
        }

        private void agenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgentePolinizador winAgente = new FormAgentePolinizador();
            winAgente.Show();
        }

        private void especiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEspecies winEspecies = new FormEspecies();
            winEspecies.Show();
        }

        private void floresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFlores winFlores = new FormFlores();
            winFlores.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(-1);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAcercaDe winAcercaDe = new FormAcercaDe();
            winAcercaDe.Show();
        }
    }
}
