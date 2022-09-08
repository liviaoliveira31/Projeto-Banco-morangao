using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBancoMorangao
{
    internal class Agencia
    {
        public int Id { get; set; }


        public Endereco Endereco { get; set; }
        //public Funcionario Funcionario { get; set; }


        public Agencia()
        {

        }
        public Agencia(int id, Endereco endereco)
        {
            Id = id;
            Endereco = endereco;
        }

        public string MostrarAgenciaCadastrada()
        {
            return "\nID: " + Id + "\nEndereço:" + Endereco.MostrarEndereco();
        }

    }
}
