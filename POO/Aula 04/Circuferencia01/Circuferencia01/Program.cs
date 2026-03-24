using static System.Console;
using static System.ConsoleColor;

Title = "Calculadora 01";

//Declaração de variaveis
double raio;
const double PI = 3.14;

//entrada de dados
Console.WriteLine("Entre com o valor do raio da circuferencia: ");
ForegroundColor = Red;
raio = double.Parse(ReadLine());
ResetColor();

// Saída de dados
WriteLine($"Circunferência: {Circunferencia(raio):F2}");
WriteLine($"Volume: {Volume(raio):F2}");
WriteLine($"PI: {PI:F2}");

// Cálculo da circunferência
double Circunferencia(double r)
{
    return 2 * PI * r;
}

// Calcular o volume
double Volume(double r)
{
    return (4 / 3) * PI * r * r * r;
}