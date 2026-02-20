using System.Reflection;
using static System.Console;
//Entrada de dados e saida de dados
double Base, perimetro, area, altura, diagonal;
System.Console.WriteLine("Digite a base do retângulo : ");
Base = double.Parse(ReadLine());
System.Console.WriteLine("Digite a altura do retângulo");
altura = double.Parse(ReadLine());

area = Base*altura;
perimetro = 2*Base + 2*altura;
diagonal = Math.Sqrt((Base*Base)+(altura*altura));

WriteLine($"Area é = {area}");
WriteLine($"O Perimetro é ={perimetro}");
WriteLine($"O valor da diagonal é = {diagonal}");

