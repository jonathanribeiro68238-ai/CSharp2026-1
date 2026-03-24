
namespace Circuferencia2
{
    internal class Calculadora
    {
        //campo
        public const double PI = 3.14;
        public double raio;
    
        // Construtor
        public Calculadora(double raio)
        {
            this.raio = raio;
        }
        public double Circunferencia()
        {
            return 2 * PI * raio;
        }

        public double Volume()
        {
            return (4.0 / 3.0) * PI * Math.Pow(raio, 3);
        }
    }
}