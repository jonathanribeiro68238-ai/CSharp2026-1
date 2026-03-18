using static System.Console;
namespace RetanguloComPOO
{
    internal class Retangulo    
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return (Largura * Altura);
        }

        // Método para calcular o perímetro: somar todos os largura e altura
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        // Método para calcular a diagonal: raiz quadrada de (Largura^2 + Altura^2)
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }
}
