using ExemploComPOO;
using static System.Console;
Triangulo x = new Triangulo();
Triangulo Y = new Triangulo();

WriteLine("Digite as medidas do triangulo X");
Write("Digite a medida A: ");
x.ladoA = double.Parse(ReadLine());
Write("Digite a medida B: ");
x.ladoB = double.Parse(ReadLine());
Write("Digite a medida C: ");
x.ladoC = double.Parse(ReadLine());

Console.WriteLine("Digite as medidas do triangulo Y");
Write("Digite a medida A: ");
Y.ladoA = double.Parse(ReadLine());
Write("Digite a medida B: ");
Y.ladoB = double.Parse(ReadLine());
Write("Digite a medida C: ");
Y.ladoC= double.Parse(ReadLine());

//Saída de dados
Console.WriteLine($"A área do triângulo X é de {x.Area()}");
Console.WriteLine($"A área do triângulo Y é de {Y.Area()}");