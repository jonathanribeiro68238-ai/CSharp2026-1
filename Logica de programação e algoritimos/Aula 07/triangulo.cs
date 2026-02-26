using static System.Console;
//-------entradade dados--------
double a, b, c, area, triangulo, p, i;
WriteLine("Digite o valor de A");
a = double.Parse(ReadLine());
WriteLine("Digite o valor de B");
b = double.Parse(ReadLine());
WriteLine("Digite o valor de C");
c = double.Parse(ReadLine());
//-------processamento de dados--------
p = (a + b + c) / 2;
area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
triangulo = (a * b) / 2;
if (area > triangulo)
{
    System.Console.WriteLine($"O valor da área do triângulo é {area}");
}
else
{
    System.Console.WriteLine($"O valor da área do triângulo é {triangulo}");
}
