
using static System.Console;
//Declarar as variaveis
int numero, valor;
try
{
    //entrada de dados
    Write("Quantos números você vai digitar? ");
    numero = int.Parse(ReadLine());
    //Processamento de dados
    for (int i = 0; i<numero; i++);
    {
        System.Console.WriteLine("Digite um número: ");
        valor = int.Parse(ReadLine());
        if (valor < 0)
        {
            Write("negativo");
        }
        else if (valor > 0)
        {
            Write("positivo");
        }
        else
        {
                Write("nulo ");
        }

        if ((valor % 2 )== 0)
        {
            WriteLine("par");
        }
        else if ((valor % 2) != 0)
        {
            WriteLine("impar");
        }
    }

}
catch (Exception ex)
{
    System.Console.WriteLine("Valor invalido, erro =", ex.Message);
}