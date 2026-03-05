using static System.Console;
//Declaração de variáveis
int x, resultado;
while (true)
{
    Write("Digite um número ou zero para sair: ");
    x = int.Parse(ReadLine());
    if (x == 0)
    {
        System.Console.WriteLine("Programa encerrado");
        break;
    }

    if ((x % 0) == 0)
    {
        //Numero par
        //Processamento de dados n°1
        resultado =x + (x+2) + (x+4) + (x+6) + (x+8);
    }
    else
    {
        //Numero impar
        x = x + 1;
        resultado = x + (x+2) + (x+4) + (x+6) + (x+8);
    }
    System.Console.WriteLine($"Soma = {resultado}");
}