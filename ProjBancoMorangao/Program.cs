using System;
using System.Collections.Generic;

namespace ProjBancoMorangao
{
    internal class Program
    {

        static List<Agencia> listaagencias = new List<Agencia>();

        static List<Cliente> clientes = new List<Cliente>();
        static List<Funcionario> funcionarios = new List<Funcionario>();
        static List<Gerente> gerentes = new List<Gerente>();



        static void Voltar()//função criada por motivos de preguiça de digitar
        {
            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        static void MenuPrincipal()
        {
            //listaagencias.Add(new Agencia(0, new Endereco("Carlos anselmo", 271, "Araraquara")));


            Console.Clear();
            Console.WriteLine("BEM VINDO AO BANCO MORANGÃO!\nESCOLHA SEU TIPO DE ACESSO:");
            Console.WriteLine("\n1-Funcionario\n2-Cliente\n0-sair");
            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    MenuFuncionario();
                    break;

                case 2:
                    MenuCliente();
                    break;



            }


        }

        static void MenuFuncionario()
        {
            Console.Clear();
            Console.WriteLine("Que tipo de funcionario você é?:");
            Console.WriteLine("\n1-Atendente\n2-Gerente\n0-Voltar");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    MenuAtendente();
                    break;

                case 2:
                    MenuGerente();
                    break;

                case 0:
                    MenuPrincipal();

                    break;

            }
        }

        static void MenuAtendente()
        {

            Console.Clear();
            Console.WriteLine("Escolha uma opção:\n1-Ver pedidos para aprovação\n0-Voltar para menu de funcionarios");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {

                case 1:
                    int id;
                    Console.Clear();
                    int elementos;
                    elementos = clientes.Count;
                    //Console.WriteLine("A lista tem " + clientes.Count + " elementos");

                    if (elementos == 0)
                    {
                        Console.WriteLine("Não ha pedidos para serem aprovados");
                        Voltar();
                        MenuAtendente();
                    }
                    Console.WriteLine("PEDIDOS PARA APROVAÇÃO\n\n");
                    foreach (Cliente clientescad in clientes)
                    {
                        Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
                        Console.WriteLine("NOME: " + clientescad.Nome + "  ID: " + "[" + clientescad.Id + "]");
                        Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
                    }
                    Console.WriteLine("Insira o id do pedido que deseja avaliar:");

                    id = int.Parse(Console.ReadLine());
                    foreach (Cliente clientescad in clientes)
                    {



                        if (id == clientescad.Id && clientescad.Permissao == false)
                        {
                            Console.WriteLine("..............DADOS DO CLIENTE................");
                            Console.WriteLine(clientescad.ToString());
                            Console.WriteLine("Deseja aprovar a conta? (s/n)");
                            char resp = char.Parse(Console.ReadLine());
                            while (resp != 's' && resp != 'n')
                            {
                                Console.WriteLine("Insira uma resposta valida (s/n)");
                                resp = char.Parse(Console.ReadLine());
                            }
                            if (resp == 's')
                            {
                                clientescad.Permissao = true;
                                Console.WriteLine("Conta aprovada com sucesso!");
                                //clientes.Remove(clientescad);
                                clientescad.ContaAprovada();

                                Voltar();
                                MenuAtendente();

                            }

                            else
                            {
                                Console.WriteLine("A conta foi negada com sucesso!");
                                clientes.Remove(clientescad);
                                Voltar();
                                MenuAtendente();
                            }
                        }
                    }


                    break;
                case 0:
                    MenuFuncionario();
                    break;

            }
        }

       


        static void MenuCliente()
        {
            Cliente cliente = new Cliente();
            Console.Clear();
            Console.WriteLine("Escolha uma opção:\n1-Acessar minha conta\n2- Criar uma conta\n0- Voltar");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {

                case 1:
                    MenuAcessarConta();


                    break;
                case 2:

                    Funcionario funcionario = new Funcionario();

                    Cliente novocliente;
                    string nome, Cpf, telefone;
                    DateTime DataNascimento;
                    Endereco endereco;
                    double Salario;
                    int idconta;
                    int idagencia;
                    bool cadastrook = false;

                    Console.WriteLine("Informe o nome: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Informe o CPF: ");
                    Cpf = Console.ReadLine();
                    Console.WriteLine("Informe a data de nascimento: ");

                    DataNascimento = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o telefone: ");
                    telefone = Console.ReadLine();



                    Console.WriteLine("Endereço:");
                    endereco = new Endereco();
                    Console.WriteLine("Rua: ");
                    endereco.Rua = Console.ReadLine();
                    Console.WriteLine("Numero:");
                    endereco.Numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Cidade: ");
                    endereco.Cidade = Console.ReadLine();




                    Console.WriteLine("Insira o id para acesso da sua conta");
                    idconta = int.Parse(Console.ReadLine());
                    foreach (Cliente c in clientes)
                    {
                        if (idconta == c.Id)
                        {
                            Console.WriteLine("Esse id ja esta sendo utilizado, insira outro");
                            idconta = int.Parse(Console.ReadLine());
                        }
                    }


                    Console.WriteLine("Insira o ID da agencia na qual deseja se cadastrar: ");
                    foreach (Agencia i in listaagencias)
                    {
                        Console.WriteLine(i.MostrarAgenciaCadastrada());


                    }
                    idagencia = int.Parse(Console.ReadLine());


                   


                    foreach (Agencia i in listaagencias)
                    {
                        if (idagencia == i.Id)
                        {

                            Console.WriteLine("Informe o seu Salario: ");
                            Salario = double.Parse(Console.ReadLine());
                            funcionario.VerificarTipodeConta(Salario);
                            novocliente = new Cliente(idconta, nome, Cpf, DataNascimento, telefone, new Endereco(endereco.Rua, endereco.Numero, endereco.Cidade), Salario, new Agencia(idagencia, endereco));
                            clientes.Add(novocliente);
                            cadastrook = true;
                            cliente.Permissao = false;

                            Voltar();
                            MenuCliente();
                        }

                        if (cadastrook == false)
                        {
                            Console.WriteLine("Agencia não localizada");
                            Console.WriteLine("Tente novamente");
                            idagencia = int.Parse(Console.ReadLine());
                            Voltar();
                            MenuCliente();
                        }
                        else
                        {
                            if (cadastrook == true)
                            {
                                Console.Clear();
                                Console.WriteLine("Pedido encaminhado para analise, aguarde sua conta ser aprovada!");

                                Voltar();
                                MenuPrincipal();
                            }
                        }
                    }


                    break;

                case 0:
                    MenuPrincipal();
                    break;


            }

        }

        static void MenuAcessarConta()
        {
            int id;
            Console.WriteLine("Insira seu id para acessar sua conta:");
            id = int.Parse(Console.ReadLine());
            foreach (Cliente c in clientes)
            {
                if (id == c.Id && c.Permissao == true)
                {
                    Console.WriteLine("Bem vindo ao Banco Morangão, Sr(a)." + c.Nome);


                    MenuAcessoLiberado(c);
                }
                else
                {
                    if (id == c.Id && c.Permissao == false)
                    {
                        Console.WriteLine("Ola Sr(a) " + c.Nome + ", infelizmente sua conta não foi aprovada. Tente novamente mais tarde");
                        Voltar();
                        MenuCliente();
                    }

                    else
                    {
                        if (id != c.Id)
                        {
                            Console.WriteLine("ID não localizado. tente novamente ou crie uma conta.");
                            Voltar();
                            MenuCliente();
                        }
                    }
                }
            }

        }
        static void MenuAcessoLiberado(Cliente c)
        {
            Console.WriteLine("\nAgência: " + c.Agencia.Id);
            Console.WriteLine("Saldo R$: " + c.ContaC.Saldo);
            Console.WriteLine("O que deseja fazer?\n1-Sacar\n2-Depositar\n3-0 Voltar");
            int opc = int.Parse(Console.ReadLine());


            switch (opc)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Saldo: R$" + c.ContaC.Saldo);
                    c.ContaC.Sacar();
                    Voltar();
                    MenuCliente();


                    break;

                case 2:

                    Console.Clear();
                    c.ContaC.Depositar();
                    Console.WriteLine("Saldo: R$" + c.ContaC.Saldo);
                    Voltar();
                    MenuCliente();

                    break;

                case 0:
                    MenuAcessarConta();
                    break;

            }


        }


        static void MenuGerente()
        {
            //Gerente gerente = new Gerente();

            Console.Clear();
            Console.WriteLine("Escolha uma opção:\n1-Cadastrar um novo funcionario\n2-Cadastrar uma nova agencia\n3-Ver funcionarios cadastrados\n4-Ver agencias cadastradas" +
                "\n5-Ver clientes cadastrados\n6-Ver gerentes cadastrados\n0-voltar");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {

                case 1:
                    #region
                    int matricula = 0;
                    Gerente novogerente;
                    Funcionario novofuncionario;
                    string nome = "";
                    int numeroagencia;
                    char ehgerente;
                    Console.Clear();
                    Console.WriteLine("CADASTRO DE FUNCIONARIO");
                    Console.WriteLine("Informe o nome :");
                    nome = Console.ReadLine();
                    Console.WriteLine("Informe o numero da matricula: ");
                    matricula = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ele é um gerente?");
                    ehgerente = char.Parse(Console.ReadLine());
                    Console.WriteLine("A qual agencia ele pertence?");
                    foreach (Agencia i in listaagencias)
                    {
                        Console.WriteLine(i.MostrarAgenciaCadastrada());


                    }
                    numeroagencia = int.Parse(Console.ReadLine());

                    foreach (Agencia i in listaagencias)
                    {
                        if (numeroagencia == i.Id)
                        {
                            if (ehgerente == 's')
                            {
                                novogerente = new Gerente(nome, matricula, i);
                                gerentes.Add(novogerente);
                                Console.WriteLine("Funcionario do tipo Gerente cadastrado com successo!");
                                Program.Voltar();
                                MenuGerente();
                            }

                            else
                            {
                                if (ehgerente == 'n')
                                {
                                    novofuncionario = new Funcionario(nome, matricula, i);
                                    funcionarios.Add(novofuncionario);
                                    Console.WriteLine("Funcionario do tipo Atendente cadastrado com successo!");
                                    Voltar();
                                    MenuGerente();
                                }
                            }
                        }

                        else
                        {

                        }

                    }






                    break;
                #endregion

                case 2:
                    #region 


                    int numeroAgencia = 0, numeroEndereco = 0;
                    String rua = "", cidade = "";
                    Agencia novaAgencia;

                    Console.Clear();
                    Console.WriteLine("CADASTRO DE AGENCIA::");
                    Console.WriteLine("Informe o endereço:");
                    Console.Write("Cidade: ");
                    cidade = Console.ReadLine();
                    Console.Write("Rua: ");
                    rua = Console.ReadLine();
                    Console.Write("Número: ");
                    numeroEndereco = int.Parse(Console.ReadLine());
                    Console.Write("ID: ");
                    numeroAgencia = int.Parse(Console.ReadLine());

                    novaAgencia = new Agencia(numeroAgencia, new Endereco(rua, numeroEndereco, cidade));
                    listaagencias.Add(novaAgencia);

                    Voltar();
                    MenuGerente();

                    break;
                #endregion

                case 3:
                    foreach (Funcionario i in funcionarios)
                    {
                        Console.WriteLine(i.MostrarFuncionario());


                    }
                    Voltar();
                    MenuGerente();
                    break;

                case 4:
                    #region

                    foreach (Agencia i in listaagencias)
                    {
                        Console.WriteLine(i.MostrarAgenciaCadastrada());


                    }
                    Voltar();
                    MenuGerente();
                    break;
                #endregion
                case 5:
                    #region
                    foreach (Cliente i in clientes)
                    {
                        Console.WriteLine(i.ToString());


                    }
                    Voltar();
                    MenuGerente();
                    break;
                #endregion

                case 6:
                    #region
                    foreach (Gerente i in gerentes)
                    {
                        Console.WriteLine(i.VerGerente());
                    }
                    Voltar();
                    MenuGerente();
                    break;

                #endregion
                case 0:
                    MenuFuncionario();
                    break;

            }


        }




        static void Main(string[] args)
        {
            listaagencias.Add(new Agencia(0, new Endereco("Carlos anselmo", 271, "Araraquara")));

            gerentes.Add(new Gerente("Vinicius", 0001, new Agencia(0, new Endereco("Carlos anselmo", 271, "Araraquara"))));
            funcionarios.Add(new Funcionario("Joao", 0002, new Agencia(0, new Endereco("Carlos anselmo", 271, "Araraquara"))));

            listaagencias.Add(new Agencia(1, new Endereco("Francisco ", 336, "Araraquara")));
            gerentes.Add(new Gerente("Fabio", 00603, new Agencia(1, new Endereco("Francisco ", 336, "Araraquara"))));
            funcionarios.Add(new Funcionario("Felipe", 00230, new Agencia(1, new Endereco("Francisco ", 336, "Araraquara"))));

            clientes.Add(new Cliente(1, "Livia", "471.522.708.80", DateTime.Today, "16997554713", new Endereco("Carlos anselmo", 271, "Araraquara"), 1234, new Agencia(1, new Endereco("Francisco ",
                336, "Araraquara"))));
            MenuPrincipal();








        }
    }
}


