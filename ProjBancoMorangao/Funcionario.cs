using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBancoMorangao
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }

        public Agencia Agencia { get; set; }





        public Funcionario()
        { }
        public Funcionario(string nome, int matricula, Agencia agencia)
        {
            Nome = nome;
            Matricula = matricula;

            Agencia = agencia;
        }


        public string  MostrarFuncionario()
        {
            return "\nNome:" + this.Nome + "\nN° Matricula:" + this.Matricula + "\nAgencia em que esta cadastrado: " + Agencia.Id;
        }

        public void VerificarTipodeConta(double salario)
        {

            
            if (salario <= 1000)
            {
                Console.WriteLine("Conta encaminhada para aprovação. Caso aprovada, ela sera do tipo Universitaria.");
               
            }

            else
            {
                if (salario >= 1000 && salario <= 10000)
                {
                    Console.WriteLine("Conta encaminhada para aprovação. Caso aprovada, ela sera do tipo Normal");
                   
                }

                else
                {
                    if (salario > 10000)
                    {
                        Console.WriteLine("Conta encaminhada para aprovação. Caso aprovada, ela sera do tipo VIP");
                       
                    }
                }
            }

        }

        public void CadastrarCliente()
        {
            //Cliente cliente = new Cliente();
            //Console.WriteLine("Informe o nome: ");
            //cliente.Nome = Console.ReadLine();
            //Console.WriteLine("Informe o CPF: ");
            //cliente.Cpf = Console.ReadLine();
            //Console.WriteLine("Informe a data de nascimento: ");
            //cliente.DataNascimento = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Informe o telefone: ");
            //cliente.Telefone = Console.ReadLine();

            //cliente.Endereco = new Endereco();
            //Console.WriteLine("Endereço:");

            //Endereco endereco = new Endereco();
            ////endereco.CadastrarEndereco();
            //ContaCorrente contac = new ContaCorrente();
            //Console.WriteLine("Insira o id da conta");
            //contac.Id = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o Salario: ");
            //cliente.Salario = double.Parse(Console.ReadLine());
            //VerificarTipodeConta(cliente.Salario);


        }


    }
}
