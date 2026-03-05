using static System.Console;
using static System.Linq.Enumerable;
//Declaração de variáveis
int visitantes = 0, contagem = 0;
double altura_max = 0, altura_min = 0, alturas = 0;
try{
//Entrada de dados
    Write("Digite o número de visitantes: ");
    visitantes = int.Parse(ReadLine());
    Write("Digite a altura maxima: ");
    altura_max = double.Parse(ReadLine());
    Write("Digite a altura minima: ");
    altura_min = double.Parse(ReadLine());
//Processamento de dados
    foreach (int i in Range(0, visitantes))
{
    Write($"Digite a altura da pessoa nº {i+1}: ");
    alturas = double.Parse(ReadLine());
    if((alturas > altura_min) && (alturas < altura_max))
    {
        contagem++;
    }
}
System.Console.WriteLine($"O Número de pessoas que podem entrar no parque é de {contagem}");
}
catch (Exception ex)
{
    System.Console.WriteLine($"Valor invalido, digite numerais, Erro = {ex.Message}");
}
