using Figuras.Classes.Entidades;
using Figuras.Classes.Enumeracoes;
using static System.Console;

List<Forma> formas = new();

Write("Entre com a quantidadde de formas: ");
int qtd = int.Parse(ReadLine());

for (int i = 0; i < qtd; i++)
{
    WriteLine($"Dados do objeto geométrico n°{i + 1}:");
    Write($"Retângulo ou Círculo (R/C): ");
    char escolha = char.Parse(ReadLine().ToLower());
    if (escolha == 'r')
    {
        WriteLine("Qual é a cor do objeto? " +
            "\n\t1 - Vermelho " +
            "\n\t1 - Azul " +
            "\n\t1 - Amarelo " +
            "\n\t1 - Rosa ");
        int cor = int.Parse(ReadLine());
    }
}