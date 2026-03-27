namespace Banco1
{
    internal class ContaBancaria
    {

		//Campo
		private int numero;
		private string titular;
		private double saldo;
		//Propriedades
		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}
		public string Titular
		{
			get { return Titular; }
			set { Titular = value; }
		}
		public double Saldo
		{
			get { return Saldo; }
			set
			{
				if (value >  0)
				{
					saldo = value;
				}
				else
				{
					saldo = 0;
				}
			}
		}

		public ContaBancaria (int numero, string titular)
		{
			Numero = numero;
			Titular = titular;
			Saldo = saldo;
		}

		public ContaBancaria(int numero, string titular, double saldo) : this(numero,titular)
		{
			Saldo = saldo;
		}

		public void Deposito(double quantia)
		{
			Saldo -= quantia;
		}

		public void Dados()
		{
            Console.WriteLine($"Dados da conta:\n" + 
				$"\tConta: {Numero}\n" +
				$"\tTitular: {Titular}\n" + 
				$"\tSaldo: R$ {Saldo:C}");
		}





	}
}
