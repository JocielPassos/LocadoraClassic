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
    public partial class FrmTelaCategoria : Form
    {
        CategoriaDAL categoriadal = new CategoriaDAL();
        int id = 0;
        Categoria categoria = new Categoria();
    
        public FrmTelaCategoria()
        {
            InitializeComponent();
            dvgCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgCategoria.CellDoubleClick += dvgCategoria_CellDoubleClick;
        }

        private void dvgCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    // Obtém a linha em que ocorreu o duplo clique
                    DataGridViewRow row = dvgCategoria.Rows[e.RowIndex];

                    // Seleciona a linha inteira
                    row.Selected = true;
                }

                //ETAPA 1 - SELECIONAR O ID DA TABELA

                // Verifica se há alguma linha selecionada no DataGridView
                if (dvgCategoria.SelectedRows.Count > 0)
                {
                    // Obtém a linha selecionada
                    DataGridViewRow selectedRow = dvgCategoria.SelectedRows[0];

                    // Obtém o valor do campo "id" da célula selecionada
                    id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    string nome = selectedRow.Cells["Nome"].Value.ToString();
                    txtNome.Text = nome;
                    txtValorDiaria.Text = nome;
                    // Faça o que precisar com o valor do campo "id"
                    // Por exemplo, exiba-o em uma caixa de diálogo



                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal valorDiariaC = 0;
            valorDiariaC = decimal.Parse(txtValorDiaria.Text);
            //objeto VO
            
            //objeto DAL
            
            //Pegar o valor da caixinha e colocar na propriedade Nome
            categoria.Nome = txtNome.Text;
            categoria.ValorDiaria = valorDiariaC;

            //INSERIR NO BANCO DE DADOS
            categoriadal.InserirCategoria(categoria);

            //Limpar a caixa
            txtNome.Text = "";
            txtValorDiaria.Text = "";
            CarregarGrid();
            MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void dvgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FrmTelaCategoria_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
        public void CarregarGrid()
        {
            dvgCategoria.DataSource = categoriadal.ObterCategorias1();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //ETAPA 1 - SELECIONAR O ID DA TABELA
            int id = 0;
            // Verifica se há alguma linha selecionada no DataGridView
            if (dvgCategoria.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dvgCategoria.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
                MessageBox.Show("O valor do campo 'id' é: " + id.ToString());
            }

            //ETAPA 2 - ENVIAR O ID PARA DELETE

            GeneroDAL generoDAL = new GeneroDAL();
            categoriadal.ExcluirCategoria(id);
            CarregarGrid();
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            categoria.Nome = txtNome.Text;
            categoria.ValorDiaria = id;
            categoriadal.AtualizarGenero(categoria);
            txtValorDiaria.Text = "";
            CarregarGrid();
        }
    }
}
