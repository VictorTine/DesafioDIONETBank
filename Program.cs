using System;
using System.Collections.Generic;  


namespace NET.Bank
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            // Conta minhaConta = new Conta (TipoConta.PessoaFisica, 1000,500,"Victor");
            // Conta outraConta = new Conta (TipoConta.PessoaFisica, 0, 300, "Seu Zé");
            // Conta maisUmaConta = new Conta (TipoConta.PessoaJuridica, 5000, 10000, "Empresa S.A");

            // System.Console.WriteLine(minhaConta.ToString());

            string opcaoUser = ObterOpcaoUser();

            while (opcaoUser.ToUpper() != "X")
            {
                switch (opcaoUser)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "6":
                        System.Console.Clear();
                        break;
                    
                    default:
                    throw new ArgumentOutOfRangeException();
                }

                opcaoUser = ObterOpcaoUser();
            }

            System.Console.WriteLine("Obrigado por utilizar o .NET Bank, volte sempre.");
            System.Console.WriteLine();         

        }

        private static void Transferir()
        {
            System.Console.WriteLine(("Digite o número da conta de origem:"));
            int indiceContaOrigem = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine(("Digite o número da conta de origem:"));
            int indiceContaDestino = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine(("Digite o valor a ser trasnferido:"));
            double valorTransferencia = double.Parse(System.Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }

        private static void Sacar()
        {
            System.Console.WriteLine("Digite o número da conta:");
            int indiceConta = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Digite o valor a ser sacado:");
            double valorSaque = double.Parse(System.Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);
        
        }

        private static void Depositar()
        {
            System.Console.WriteLine("Digite o número da conta favorecida:");
            int indiceConta = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Digite o valor a ser depositado:");
            double valorDeposito = double.Parse(System.Console.ReadLine());

            listContas[indiceConta].Sacar(valorDeposito);
        
        }


        private static void InserirConta()
        {
            System.Console.WriteLine("Inserir Nova Conta:");

            System.Console.WriteLine("Digite 1 para Pessoa Física ou 2 para Jurídica");
            int entradaTipoConta = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Digite o nome do cliente:");
            string entradaNome = (System.Console.ReadLine());

            System.Console.WriteLine("Digite o saldo:");
            double entradaSaldo = double.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Digite o crédito:");
            double entradaCredito = double.Parse(System.Console.ReadLine());

            // Conta novaConta = Conta(tipoConta: (TipoConta)entradaTipoConta,
            //                         saldo: entradaSaldo,
            //                         credito: entradaCredito,
            //                         nome: entradaNome);
            Conta novaConta = new Conta
            {
                TipoConta = (TipoConta)entradaTipoConta,
                Credito = entradaCredito,
                Nome = entradaNome,
                Saldo = entradaSaldo
            };

             listContas.Add(novaConta);

            
        }

        private static void ListarContas()
        {
            System.Console.WriteLine("Listar Contas");

            if (listContas.Count == 0)
            {
                System.Console.WriteLine("Nenhuma conta à listar.");
                return;
            }

            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                System.Console.WriteLine("#{0} . ", i);
                System.Console.WriteLine(conta);

            }

        }

        private static string ObterOpcaoUser()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Bom vindo ao NET Bank");
            System.Console.WriteLine("Digite a opção desejada: ");

            System.Console.WriteLine("1 - Listar Contas");
            System.Console.WriteLine("2 - Abrir Conta");
            System.Console.WriteLine("3 - Transferir");
            System.Console.WriteLine("4 - Sacar");
            System.Console.WriteLine("5 - Depositar");
            System.Console.WriteLine("6 - Limpar Tela");
            System.Console.WriteLine("X - Sair");
            System.Console.WriteLine();

            string opcaoUser = System.Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaoUser;




        }
    }
}
