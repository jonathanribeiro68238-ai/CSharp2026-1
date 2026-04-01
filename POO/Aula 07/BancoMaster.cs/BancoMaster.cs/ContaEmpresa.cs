namespace BancoMaster
{
    internal class ContaEmpresa : Conta
    {
     

        public double LimiteEmprestimo
		{
            get { return limite; }
            set { limite = value; }
		}
  public ContaEmpresa(int numeroConta, string titularConta) : base(numeroConta, titularConta)
        {
            LimiteEmprestimo = limite;
        }

        public ContaEmpresa(int numeroConta, string titularConta, double saldoConta) : base(numeroConta, titularConta, saldoConta)
        {
        }



	}
}
 