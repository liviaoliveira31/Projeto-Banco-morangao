using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBancoMorangao
{
    internal class Endereco
    {
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }


       public void Voltar()//função criada por motivos de preguiça de digitar
        {
            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
        }
        public Endereco()
        {

        }

        public Endereco(string rua, int numero,string cidade)
        {
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
           
        }

        //public Endereco CadastrarEndereco()
        //{
        //    Console.WriteLine("Informe o nome da rua:");
        //    string rua = Console.ReadLine();

        //    Console.WriteLine("Informe o numero do local:");
        //    int numero = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe a cidade:");
        //    string cidade = Console.ReadLine();

        //    return new Endereco(rua, numero, cidade);
        //}


        public String MostrarEndereco()
        {
            return "\nCidade: " + this.Cidade + "\nRua: " + this.Rua  + "\nNúmero: " + this.Numero;
        }
    }
}
