namespace BancoMaster
{
    internal class ContaPoupança : Conta
    {
        //Campo
        private double juros;


      //Propriedade

        public double TaxaDeJuros
        {
            get { return juros; }
            set { juros = value; }
        }


        //Construtores
        public ContaPoupança(int numeroConta, string titularConta, double TaxaJuros) : base(numeroConta, titularConta)
        {
            TaxaDeJuros = TaxaJuros;
        }

        public ContaPoupança(int numeroConta, string titularConta, double saldoConta, double TaxaJuros) : base(numeroConta, titularConta, saldoConta)
        {
            TaxaDeJuros = TaxaJuros;
        }

        //Métodos
        public void AtualizacaoDeSaldo()
        {
            SaldoConta = SaldoConta + (SaldoConta * TaxaDeJuros);
        }

        public override void Saque(double qtd)
        {
            SaldoConta -= qtd;
        }


    }
}

