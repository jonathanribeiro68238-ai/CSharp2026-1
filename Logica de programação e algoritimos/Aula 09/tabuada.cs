using static System.Console;

//Declaração de variavel
int numero;
//Entrada de dados
numero = int.Parse(ReadLine());
//Processamento de dados
for (int i = 1; i <= 10; i++)
{
    System.Console.WriteLine($"{numero}x{i+1} = {numero * (i+1)}");
}