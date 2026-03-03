using System.Linq.Expressions;
using static System. console;
//O usuario vai digitar o codigo do produto e a quantidade do produto e o programa vai mostrar o valor a ser pago pelo produto escolhido pelo usuario
static void Total(int qtd, double valor)
{
    System.Console.WriteLine($"Valor total a ser pago: R${qtd * valor}");
}


//-----declaração de variaveis------
int codigo, quantidade;
//entrada de dados
try{

System.Console.WriteLine("Digite o código do produto:");
codigo = int.Parse(Console.ReadLine());
System.Console.WriteLine("Digite a quantidade do produto:");
quantidade = int.Parse(Console.ReadLine());

switch (codigo)
{
    case 1:
        Total(quantidade, 5.0);
        //System.Console.WriteLine($"Valor total é de: R${quantidade * 5.0}");
        break;
    case 2:
        Total(quantidade, 4.50);
        //System.Console.WriteLine($"Valor total é de: R${quantidade * 4.50}");
        break;
    case 3:
        Total(quantidade, 3.75);
        //System.Console.WriteLine($"Valor total é de: R${quantidade * 3.75}");
        break;
    case 4:
        Total(quantidade, 8.99);
        //System.Console.WriteLine($"Valor total é de: R${quantidade * 8.99}");
        break;
    case 5:
        Total(quantidade, 11.33);
        //System.Console.WriteLine($"Valor total é de: R${quantidade * 11.33}");
        break;
    default:
        System.Console.WriteLine("Código Invalido");
        break;
    }
}   
catch (Exception ex)
{
    System.Console.WriteLine("Digite valores válidos, erro: {ex.Message}");
}