namespace Master.cs
{
    internal class ContaPJ : Conta
    {
        //Campo
		private double limite;


        //Propriedade
        public double LimiteConta
		{
			get { return limite; }
			set { limite = value; }
		}

        //Construtor
        public ContaPJ(int numeroConta, double saldoConta, Pessoa dadosCliente) : base(numeroConta, saldoConta, dadosCliente)
        {
            LimiteConta = limite;
        }
        public void Emprestimo(double qtd)
        {
            LimiteConta -= qtd;
            SaldoConta += qtd;
        }
	}
}
