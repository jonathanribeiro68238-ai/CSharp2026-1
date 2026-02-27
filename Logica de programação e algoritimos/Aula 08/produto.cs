using static System. console;
//O usuario vai digitar o codigo do produto e a quantidade do produto e o programa vai mostrar o valor a ser pago pelo produto escolhido pelo usuario


int codigo, quantidade;
//entrada de dados

System.Console.WriteLine("Digite o código do produto:");
codigo = int.Parse(Console.ReadLine());
System.Console.WriteLine("Digite a quantidade do produto:");
quantidade = int.Parse(Console.ReadLine());

switch (codigo)
{
    case 1:
        System.Console.WriteLine("Cachorro quente");
        break;
    case 2:
        System.Console.WriteLine("X-Salada");
        break;
    case 3:
        System.Console.WriteLine("X-Bacon");
        break;
    case 4:
        System.Console.WriteLine("Torrada Simples");
        break;
    case 5:
        System.Console.WriteLine("Refrigerante");
        break;
    default:
        System.Console.WriteLine("Código Invalido");
        break;
}