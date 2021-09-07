using System;

namespace NET.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta (TipoConta.PessoaFisica, 1000,500,"Victor");
            Conta outraConta = new Conta (TipoConta.PessoaFisica, 0, 300, "Seu Zé");
            Conta maisUmaConta = new Conta (TipoConta.PessoaJuridica, 5000, 10000, "Empresa S.A");

            System.Console.WriteLine(minhaConta.ToString());

            string opcaoUser = ObterOpcaoUser();

            while (opcaoUser.ToUpper() != "X")
            {
                switch (opcaoUser)
                {
                    case "1":
                        //ListarContas();
                        break;
                    case "2":
                        //InserirConta();
                        break;
                    case "3":
                       // Transferir();
                        break;
                    case "4":
                        //Sacar();
                        break;
                    case "5":
                        //Depositar();
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
