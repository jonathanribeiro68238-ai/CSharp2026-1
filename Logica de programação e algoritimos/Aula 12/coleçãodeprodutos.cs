using static System.Console;
//----Entradada de dados------
System.Console.WriteLine("Produto 1 = R$ 5,00");
System.Console.WriteLine("Produto 2 = R$ 3,50");
System.Console.WriteLine("Produto 3 = R$ 4,80");
System.Console.WriteLine("Produto 4 = R$ 8,90");
System.Console.WriteLine("Produto 5 = R$ 7,32");

Dictionary<int, double> pessoas = new Dictionary<int, double>()
{
    {1, 5.00},
    {2, 3.50},
    {3, 4.80},
    {4, 8.90},
    {5  , 7.32}
};

System.Console.WriteLine("Digite o codigo do produto: ");
int produto = int.Parse(Console.ReadLine());
System.Console.WriteLine("Digite a quantidade do produto: ");
int quantidade = int.Parse(Console.ReadLine());
if (pessoas.ContainsKey(produto))
{
    double valor = pessoas[produto] * quantidade;
    System.Console.WriteLine($"Valor a ser pago: R$ {valor}");
}
else
{
    System.Console.WriteLine("Produto não encontrado");
}

