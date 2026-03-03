using static System.Console;
//Declaraçao de variaveis
int PessoasPermitidas=0;
{
    System.Console.WriteLine("Digite o numero de visitantes: ");
    int numeroVisitantes = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite a altura minima permitida (em cm): ");
    int alturaMinima = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite a altura maxima permitida (em cm): ");
    int alturaMaxima = int.Parse(Console.ReadLine());

    int podemAndar = 0;

    for ( int i = 1; i<numeroVisitantes; i++)
    {
        Console.Write($"Digite a altura da pessoa {i} (em cm): ");
        double altura = double.Parse(Console.ReadLine());

        if (altura >= alturaMinima & altura <= alturaMaxima)
        {
            PessoasPermitidas++;
        }
    }
    System.Console.WriteLine($"Quantidade de pessoas que podem andar na montanha-russa: {PessoasPermitidas}");

}

