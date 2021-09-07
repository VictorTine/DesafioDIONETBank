using System;
namespace NET.Bank {
    public class Conta{
        private TipoConta TipoConta { get; set; }
        private string Nome { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
    {
        this.TipoConta = tipoConta;
        this.Saldo = saldo;
        this.Credito = credito;
        this.Nome = nome;
        
    }

        public bool Sacar(double valorSaque){
            if (valorSaque > this.Saldo + this.Credito)
            {
	            System.Console.WriteLine("Saldo Insificiente.");
	            return false;
            }
            else
            {
                this.Saldo -= valorSaque;
	            //this.Saldo = this.Saldo - valorSaque;
                System.Console.WriteLine("{0}, seu saldo é de:{}.",this.Nome,this.Saldo);
                return true;
            }
        }
            public void Depositar(double valorDeposito)
            {
            this.Saldo += valorDeposito;
            System.Console.WriteLine("O saldo atual da conta {0} é de: {1}", this.Nome, this.Saldo);
            }

            public void Transferir(double valorTransferencia, Conta contaDestino){
                if(this.Sacar(valorTransferencia))
                {
                    contaDestino.Depositar(valorTransferencia);
                }
            }

            public override string ToString()
            {
                string retorno ="";
                retorno += "TipoConta " + this.TipoConta + " | ";
                retorno += "Nome " + this.Nome + " | ";
                retorno += "Saldo " + this.Saldo + " | ";
                retorno += "Credito" + this.Credito + " | ";
                return retorno;

            }
    }


}

