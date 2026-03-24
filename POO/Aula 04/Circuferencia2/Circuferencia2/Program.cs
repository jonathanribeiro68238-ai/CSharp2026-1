using static System.Console;
using static System.ConsoleColor;
using Circuferencia2;



//entrada de dados
Console.WriteLine("Digite os raios da cicuferencia: ");
ForegroundColor = ConsoleColor.Red;
         

// Lê a entrada e converte para double
double raio = double.Parse(ReadLine());
ResetColor();

            // Criar o objeto do tipo Calculadora
Calculadora c1 = new Calculadora(raio);

// Saída de dados
WriteLine($"Circunferencia: {c1.Circunferencia():F2}");
WriteLine($"Volume: {c1.Volume():F2}");

            ReadKey();
 