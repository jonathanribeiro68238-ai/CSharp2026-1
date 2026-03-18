using static System.Console;
//Entrada de dados
Console.WriteLine("Digite as medidasdo triângulo x");
Write("Digite o valor de a: ");
double ax = double.Parse(ReadLine());
Write("Digite o valor de b: ");
double  bx = double.Parse(ReadLine());
Write("Digite o valor de c: ");
double cx = double.Parse(ReadLine());

Console.WriteLine("Digite as medidas do triângulo Y");
Write("Digite o valor de a: ");
double ay = double.Parse(ReadLine());
Write("Digite o valor de b: ");
double by = double.Parse(ReadLine());
Write("Digite o valor de c: ");
double cy = double.Parse(ReadLine());

//Processamento de dados
double px = (ax + bx + cx) / 2;
double py = (ay + by + cy) / 2;
double areax = Math.Sqrt(px * (px - ax) * (px - bx) * (px - cx));
double areay = Math.Sqrt(py * (py - ay) * (py - by) * (py - cy));

//Saída de dados
Console.WriteLine($"A área do triângulo x é de {areax:.F2}");
Console.WriteLine($"A área do triângulo y é de {areay:.F2}");

if (areax > areay)
{
    Console.WriteLine("Maior área é triângulo X");
}
else if (areay > areax)
{
    Console.WriteLine("Maior área do triângulo Y");
}
else
{
    Console.WriteLine("Os triângulos de áreas iguais");
}
ReadKey();