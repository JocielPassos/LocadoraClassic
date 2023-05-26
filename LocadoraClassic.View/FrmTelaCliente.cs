using LocadoraClassic.DAL;
using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LocadoraClassic.View
{
    public partial class FrmTelaCliente : Form
    {
        ClienteDAL clientedal = new ClienteDAL();


        public FrmTelaCliente()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //objeto VO
            Cliente cliente = new Cliente();

            ClienteDAL clientedal = new ClienteDAL();
            //objeto DAL

            //Pegar o valor da caixinha e colocar na propriedade Nome
            cliente.Nome = txtNome.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Celular = txtCelular.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Rg = txtRg.Text;

           
            //INSERIR NO BANCO DE DADOS
            clientedal.InserirCliente(cliente);

            //Limpar a caixa
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCelular.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";

            CarregarGrid();
            MessageBox.Show("Dados inseridos com sucesso!");
        }
        private void FrmTelaCliente_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
      public void CarregarGrid()
        {
            dvgCliente.DataSource = clientedal.ObterCliente().ToList();
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //objeto VO
            Cliente cliente = new Cliente();

            ClienteDAL clientedal = new ClienteDAL();
            //objeto DAL

            //Pegar o valor da caixinha e colocar na propriedade Nome
            cliente.Nome = txtNome.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Celular = txtCelular.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Rg = txtRg.Text;
            


            //INSERIR NO BANCO DE DADOS
            clientedal.InserirCliente(cliente);

            //Limpar a caixa
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCelular.Text = "";
            txtCpf.Text = "";
            txtRg.Text = "";

            CarregarGrid();
            MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //ETAPA 1 - SELECIONAR O ID DA TABELA
            int id = 0;
            // Verifica se há alguma linha selecionada no DataGridView
            if (dvgCliente.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = dvgCliente.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
                MessageBox.Show("O valor do campo 'id' é: " + id.ToString());
            }

            //ETAPA 2 - ENVIAR O ID PARA DELETE

            GeneroDAL generoDAL = new GeneroDAL();
            clientedal.ExcluirClientes(id);
            CarregarGrid();
        }
    }
}
