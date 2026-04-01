

namespace BancoMaster
{
    internal class Conta
    {
        private int numero;
        private string titular;
        private double saldo;

        public int NumeroConta
        {
            get { return numero; }
            set { numero = value; }
        }

        private int myVar;

        public string TitularConta
        {
            get { return titular; }
            set { titular = value; }
        }
       


        public double SaldoConta
        {
            get { return saldo; }
            set { saldo = value; }
        }
        //Construtores
        public Conta(int numeroConta, string titularConta, double saldoConta)
        {
            this.titular = titular;
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            SaldoConta = saldoConta;
        }

        public Conta(int numeroConta, string titularConta) : this(numeroConta, titularConta, 0)
        {
            SaldoConta = 0;
        }

        //Métodos

        public virtual void Saque(double qtd)
        {
            saldo -= qtd + 5.00;
        }

        public void Deposito(double qtd)
        {
            SaldoConta += qtd;
        }



    }
}
