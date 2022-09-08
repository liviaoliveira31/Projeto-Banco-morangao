using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBancoMorangao
{
    internal class Cliente
    {

        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
        public double Salario { get; set; }
        public bool Permissao { get; set; }
        public Agencia Agencia { get; set; }
   
        public ContaCorrente ContaC { get; set; }
      


        public Cliente()
        {

        }

        public void ContaAprovada()
        {
            this.Permissao = true;

            this.ContaC = new ContaCorrente(this.Id, this.Agencia, 0);
        }
        public Cliente(int id, string nome, string cpf, DateTime dataNascimento, string telefone, Endereco endereco, double salario, Agencia agencia)//, ContaPoupanca contaP, Cartao cartaodeCredito)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Endereco = endereco;
            Salario = salario;
            Permissao = Permissao = false;
            ContaC = ContaC;
            Agencia = agencia;
        }

        public override string ToString()

            
        {
            string resp;
            if (Permissao == false)
                resp = "Não";
            else resp = "Sim";
            
                return "Nome: " + Nome + "\nCPF: " + Cpf + "\nData de nascimento: " + DataNascimento.ToLongDateString() + "\nTelefone: " + Telefone + "\nEndereço:" + Endereco.MostrarEndereco()+ "\nConta Aprovada?: "+ resp;
        }

        public void SolicitarAbertura()
        {


        }

       
        public void AcessarConta()
        {

        }

    }
}
