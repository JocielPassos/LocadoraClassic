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

            FrmTelaGenero frmtelagenero = new FrmTelaGenero();

            panel1.Controls.Clear();

            frmtelagenero.TopLevel = false;

            panel1.Controls.Add(frmtelagenero);

            frmtelagenero.Show();

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

            FrmTelaCategoria frmtelacategoria = new FrmTelaCategoria();

            panel1.Controls.Clear();

            frmtelacategoria.TopLevel = false;

            panel1.Controls.Add(frmtelacategoria);

            frmtelacategoria.Show();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmTelaFilme frmtelafilme = new FrmTelaFilme();

            panel1.Controls.Clear();

            frmtelafilme.TopLevel = false;

            panel1.Controls.Add(frmtelafilme);

            frmtelafilme.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            

            FrmTelaCliente frmtelacliente = new FrmTelaCliente();

            panel1.Controls.Clear();

            frmtelacliente.TopLevel = false;

            panel1.Controls.Add(frmtelacliente);

            frmtelacliente.Show();
        }

        private void realizarLocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmTelaLocacao frmtelalocacao = new FrmTelaLocacao();

            panel1.Controls.Clear();

            frmtelalocacao.TopLevel = false;

            panel1.Controls.Add(frmtelalocacao);

            frmtelalocacao.Show();
        }
    }
}
