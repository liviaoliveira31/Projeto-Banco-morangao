using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBancoMorangao
{
    internal class ContaCorrente
    {
        public int Id { get; set; }

        public Agencia Agencia { get; set; }

        public double Saldo { get; set; }
        //public double ChequeEspecial { get; set; }


        public ContaCorrente()
        {

        }

        //public ContaCorrente(int id)
        //{
        //    Id = id;
        //}

        //public ContaCorrente(int id, Agencia agencia)
        //{
        //    Id = id;
        //    Agencia = agencia;
        //}

        public ContaCorrente(int id, Agencia agencia, double saldo)
        {
            Id = id;
            Agencia = agencia;
            Saldo = saldo;

        }
        public void VerSaldo()
        {
            Console.WriteLine("O seu saldo atual é:" + Saldo);

        }

        public void Sacar()
        {

            Console.WriteLine("Informe o valor desejado para saque");
            double valorsaque = double.Parse(Console.ReadLine());


            if (valorsaque > Saldo)
            {
                Console.WriteLine("O saldo atual é insuficiente para realizar o saque!");
                Console.WriteLine("Saldo: " + Saldo);


            }
            else
            {
                Saldo = Saldo - valorsaque;
                Console.WriteLine("Saldo: " + Saldo);
            }


        }

        public void Depositar()
        {

            Console.WriteLine("Qual valor deseja depositar?:");
            double valordeposito = double.Parse(Console.ReadLine());

            Saldo = Saldo + valordeposito;

        }


    }
}
