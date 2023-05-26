using LocadoraClassic.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraClassic.VO;


namespace LocadoraClassic.View
{
    public partial class FrmTelaGenero : Form
    {
        Genero genero = new Genero();
        int id = 0;
        GeneroDAL generoDAL = new GeneroDAL();
        public FrmTelaGenero()
        {
            InitializeComponent();
            dvgGenero.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgGenero.CellDoubleClick += dvgGenero_CellDoubleClick;
        }

        private void dvgGenero_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    // Obtém a linha em que ocorreu o duplo clique
                    DataGridViewRow row = dvgGenero.Rows[e.RowIndex];

                    // Seleciona a linha inteira
                    row.Selected = true;
                }

                //ETAPA 1 - SELECIONAR O ID DA TABELA

                // Verifica se há alguma linha selecionada no DataGridView
                if (dvgGenero.SelectedRows.Count > 0)
                {
                    // Obtém a linha selecionada
                    DataGridViewRow selectedRow = dvgGenero.SelectedRows[0];

                    // Obtém o valor do campo "id" da célula selecionada
                    id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    string nome = selectedRow.Cells["Nome"].Value.ToString();
                    txtGenero.Text = nome;
                    // Faça o que precisar com o valor do campo "id"
                    // Por exemplo, exiba-o em uma caixa de diálogo



                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //objeto VO
           

            
            //objeto DAL

            //Pegar o valor da caixinha e colocar na propriedade Nome
            genero.Nome = txtGenero.Text;

            //INSERIR NO BANCO DE DADOS
            generoDAL.InserirGenero(genero);

            //Limpar a caixa
            txtGenero.Text = "";
            CarregarGrid();
            MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void FrmTelaGenero_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            dvgGenero.DataSource = generoDAL.ObterGeneros().ToList();
        }

        private void dgvGeneros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Excluir(object sender, EventArgs e)
        {
            
                //ETAPA 1 - SELECIONAR O ID DA TABELA
                int id = 0;
                // Verifica se há alguma linha selecionada no DataGridView
                if (dvgGenero.SelectedRows.Count > 0)
                {
                    // Obtém a linha selecionada
                    DataGridViewRow selectedRow = dvgGenero.SelectedRows[0];

                    // Obtém o valor do campo "id" da célula selecionada
                    id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    // Faça o que precisar com o valor do campo "id"
                    // Por exemplo, exiba-o em uma caixa de diálogo
                    MessageBox.Show("O valor do campo 'id' é: " + id.ToString());
                }

            //ETAPA 2 - ENVIAR O ID PARA DELETE

            GeneroDAL generoDAL = new GeneroDAL();
            generoDAL.ExcluirGenero(id);
            CarregarGrid();

        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            genero.Nome = txtGenero.Text;
            genero.Id = id;
            generoDAL.AtualizarGenero(genero);
            txtGenero.Text = "";
            CarregarGrid();
        }
    }
}
