using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBancoMorangao
{
    internal class Gerente : Funcionario
    {
        List<Agencia> listaagencias = new List<Agencia>();
        List<Cliente> clientes = new List<Cliente>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        List<Gerente> gerentes = new List<Gerente>();
        public Gerente()
        {

        }

        public Gerente(String nome, int matricula, Agencia agencia) : base(nome, matricula, agencia)
        {

        }


        public string VerGerente()
        {
            return "\nNome: " + this.Nome + "\nN° Matricula: " + this.Matricula + "\nPertence a agencia:" + Agencia.Id;
        }

        public void CadastrarFuncionario()
        {

        }


    }
}

//        public void CadastrarAgencia()
//        {





//            //novaAgencia = new Agencia(numeroAgencia, new Endereco(rua, numeroEndereco, cidade));
//            //listaagencias.Add(novaAgencia);

//            //listaagencias.ForEach(i => Console.WriteLine(i));





//        }



//        public void AprovarConta()
//        {

//        }



//        void VerFuncionariosCadastrados()
//        {

//        }

//        public void VerAgenciasCadastradas()
//        {
//            //foreach (Agencia a in listaagencias)
//            //{
//            //    //Console.WriteLine(agencia);
//            //    Console.WriteLine( a);
//            //}

//        }
//    }
//}
