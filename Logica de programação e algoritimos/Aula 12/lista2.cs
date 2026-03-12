//Exercicio de lista com a estrutura de repetição for
using System.Threading.Tasks.Dataflow;
using static System.Console;

//------Declaração de variáveis------
int n;
List<double> numeros = new List<double>();
//------Entrada de dados------
Write("Quantos números você digitar: ");
n = int.Parse(ReadLine());

for (int i = 0; i < n; i++)
{
    System.Console.WriteLine("Digite um número: ");
    numeros.Add(double.Parse(ReadLine()));
}

for (int i = 0; i < n ; i++)
{
    Write($" {numeros[i]}");
}

Write($"\nSoma = {numeros.Sum()}");
Write($"\nMédia = {numeros.Average()}");
