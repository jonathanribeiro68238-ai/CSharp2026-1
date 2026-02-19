using static System.Console;
//Declarando de variáveis
double largura, comprimento, valor, area, preco;
//Entrada de dados
WriteLine("Digite a largura do terreno: ");
largura = double.Parse(ReadLine());
WriteLine("Digite o comprimento do terreno: ");
comprimento = double.Parse(ReadLine());
Write("Digite o valor do m² quadrado: ");
valor = double.Parse(ReadLine());
//Processamento de dados
area = largura * comprimento;
preco = area * valor;
//Saida de dados
WriteLine($"A área do terreno é de {area} e o preço do terreno é de R${preco}");