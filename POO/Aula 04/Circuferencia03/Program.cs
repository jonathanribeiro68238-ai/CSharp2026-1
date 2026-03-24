using static System.Console;
using static System.ConsoleColor;
using static Circuferencia03.Calculadora;

Title = "Calculadora03";
//Entrada de dados
Write("Digite o raio da circuferencia: ");
ForegroundColor = Red;
double raio = double.Parse(ReadLine());
ResetColor();
//Saída de dados
Console.WriteLine($"Cicunferencia: {Circuferencia(raio):F2}");
Console.WriteLine($"Volume: {Volume(raio):F2}");
Write($"PI: {PI}");