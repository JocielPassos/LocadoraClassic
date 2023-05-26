using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Celular { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }


        public Cliente()
        {

        }
        public Cliente(int id, string nome, string endereco, string celular, string cpf, string rg)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Celular = celular;
            Cpf = cpf;
            Rg = rg;

        }
        public Cliente(string nome)
        {
            Nome = nome;
        }

       
    }

}
