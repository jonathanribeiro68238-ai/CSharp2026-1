

namespace Class1
{
    internal class Funcionario
    {
        public string nome;
        public double SalarioBruto;
        public double imposto;
        public double SalarioLiquido()
        {
            return SalarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * porcentagem / 100.0;
        }

        

    }
}
