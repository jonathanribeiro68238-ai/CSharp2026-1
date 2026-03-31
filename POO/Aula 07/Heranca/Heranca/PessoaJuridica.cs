namespace Heranca
{
    internal class PessoaJuridica : PessoaFisica
    {
        private double limite;

        private double LimiteEmprestimo;

        public double MyProperty
        {
            get { return limite; }
            set { limite = value; }
        }

        //Construtores
        public PessoaJuridica(string titularConta, double limiteConta, int numeroConta) : base(titularConta, numeroConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        public PessoaJuridica(double saldoConta, double limiteConta, string titularConta, int numeroConta) : base(saldoConta, titularConta, numeroConta)
        {
            LimiteEmprestimo = limiteConta;
        }

        //Métodos
        public void Limite(double quantia)
        {
            SaldoConta += quantia;
        }

    }
}
