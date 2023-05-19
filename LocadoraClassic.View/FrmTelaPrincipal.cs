using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraClassic.View
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void generoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTelaGenero frmTelaGenero = new FrmTelaGenero();
            frmTelaGenero.ShowDialog();//show é um método
            this.Show();
            

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTelaCategoria frmtelacategoria = new FrmTelaCategoria();
            frmtelacategoria.ShowDialog();
            this.Show();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTelaFilme frmtelafilme = new FrmTelaFilme();
            frmtelafilme.ShowDialog();
            this.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FrmTelaCliente frmtelacliente = new FrmTelaCliente();
            frmtelacliente.ShowDialog();
            this.Show();
        }
    }
}
