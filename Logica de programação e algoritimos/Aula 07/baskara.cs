using static System.Console;

//problema Baskara
//-----Declaração de variaveis----
double a, b, c, delta, x1, x2;
//-----entrada de dados-------
Write("Digite o valor de a: ");
a = double.Parse(ReadLine());
Write("Digite o valor de b: ");
b = double.Parse(ReadLine());
Write("Digite o valor de c: ");
c = double.Parse(ReadLine());
//------processamento de dados-------
delta = (b*b) - (4 * a * c);
//-----Estrutura de controle de decisão - IF ------
if (delta < 0)
{
    System.Console.WriteLine("Raizes impossiveis");
}
else if (delta == 0)
{
    x1 = -b/ (2*a);
    x2 = x1;
}
else
{
    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    System.Console.WriteLine($"X1 = {x1}\nx2 = {x2}");
}