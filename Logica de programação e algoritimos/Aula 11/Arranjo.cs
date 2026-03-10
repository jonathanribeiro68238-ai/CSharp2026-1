using static System.Console;
using static System.Linq.Enumerable;
//Declaração de variáveis
int n;
//Entrada de dados
Write("Quantos números você vai digitar? ");
n = int.Parse(ReadLine());
if (n < 0)
{
    System.Console.WriteLine("Valor invalido, digite somente números positivos");
}
else if (n > 10)
{
    System.Console.WriteLine("Máximo de valores para digitar igual a 10");
    System.Console.WriteLine("Tente novamente!");
}
else
{
    //declaração de vetor
    int[] numeros = new int[n];
    for (int i = 0; i < n; i++)
    {
        Write("Digite um número: ");
        numeros[i] = int.Parse(ReadLine());
    }

    System.Console.WriteLine("NUMEROS NEGATIVOS:");
    foreach (int item in Range(0, numeros.Length))
    {
        if (numeros[item] < 0)
        {
            System.Console.WriteLine(numeros[item]);
        }
    }
}