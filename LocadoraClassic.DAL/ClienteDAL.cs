using LocadoraClassic.VO;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.DAL
{
    public class ClienteDAL
    {
        public object DataSource { get; set; }

        public void ExcluirCliente(int id)
        {
            throw new NotImplementedException();
        }

        public void InserirCliente(Cliente cliente)
        {
            //Abrir a Conexão
            Conexao.Instance.Open();

            //MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            //DML - INSERT - DELETE - UPDATE -SELECT
            //STORED PROCEDURES
            //ADO.NET - biblioteca de banco de dados do .NET
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO cliente(nome, endereco, celular, cpf, rg)values(@nome, @endereco, @celular, @Cpf, @Rg)";
            comando.Parameters.Add(new MySqlParameter("@nome", cliente.Nome));
            comando.Parameters.Add(new MySqlParameter("@endereco", cliente.Endereco));
            comando.Parameters.Add(new MySqlParameter("@celular", cliente.Celular));
            comando.Parameters.Add(new MySqlParameter("@cpf", cliente.Cpf));
            comando.Parameters.Add(new MySqlParameter("@rg", cliente.Rg));
            comando.ExecuteNonQuery();
            Conexao.Instance.Close();

        }
        public List<Cliente> ObterCliente()
        {
            //Abrir a Conexão
            Conexao.Instance.Open();
            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM cliente";
            // Executar o comando e obter o resultado
            MySqlDataReader reader = comando.ExecuteReader();
            List<Cliente> clientes = new List<Cliente>();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["id"]);

                cliente.Nome = reader["nome"].ToString();
                cliente.Endereco = reader["endereco"].ToString();
                cliente.Celular = reader["celular"].ToString();
                cliente.Cpf = reader["cpf"].ToString();
                cliente.Rg = reader["rg"].ToString();
                clientes.Add(cliente);

            }
            // Fechar a conexão e retornar os gêneros obtidos
            reader.Close();
            Conexao.Instance.Close();
            return clientes;
        }
        public void ExcluirClientes(int id)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM cliente WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            // Fechar a conexão
            Conexao.Instance.Close();
        }

        public object ObterClientes()
        {
            throw new NotImplementedException();
        }
    }
}