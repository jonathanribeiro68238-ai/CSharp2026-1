namespace Banco
{
    internal class ContaBancaria
    {
        //Campos
        private int Numero;
        private string titular;
        private double saldo;

        //Construtor
        public ContaBancaria(int Numero, string titular)
        {
            this.Numero = Numero;
            this.titular = titular;
            saldo = 0;
        }

        public ContaBancaria(int Numero, string titular, double saldo) :this(Numero, titular)
        {
            this.saldo = saldo;
        }

        //Métodos
        public void Deposito(double quantia)
        {
            saldo += quantia;
        }

        public void Saque(double quantia)
        {
            saldo -= quantia; 
        }

        public void Dados()
        {
            Console.WriteLine("Dados da conta cadastrada: ");
            Console.WriteLine($"\tTitular: {titular}\n" +
                $"\tNumero da conta: {Numero}\n" +
                $"\tsaldo da conta: R$ {saldo}");
        }
    }
}
