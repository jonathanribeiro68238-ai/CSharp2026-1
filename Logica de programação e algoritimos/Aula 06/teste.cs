using System.Reflection;
using static System.Console;
//declaração de dados
int a;
int b;
int c;
//entrada de dados
Console.Write("Digite o primeiro valor: ");
a = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo valor: ");
b = int.Parse(Console.ReadLine());
Console.Write("Digite o terceiro valor: "); 
c = int.Parse(Console.ReadLine());
//number 1
bool resultado1 = a ==c;
System.Console.WriteLine($"O primeiro valor é igual ao terceiro valor ?");
//number 2
bool resultado2 = b != a;
System.Console.WriteLine($"O segundo valor é diferente do primeiro valor ?");
//number 3
bool resultado3 = b>c;
System.Console.WriteLine($"O segundo valor é maior que o terceiro valor ?");
//number 4
bool resultado4 = a <= c;
System.Console.WriteLine($"O primeiro valor é menor ou igual que terceiro valor ?");
//2° parte
bool etapa2 = resultado1 & resultado3;
System.Console.WriteLine($"Se a primeira pergunta e a pergunta tres são verdadeiras?");
bool etapa3 = resultado2 & resultado4;
System.Console.WriteLine($"A segunda pergunta e a pergunta quatro pelomenos uma é verdadeira");
bool etapa4 = !resultado1;
System.Console.WriteLine($"A negação da primeira pergunta é veradeira");
