using static System.Console;
using Class1;

    
Funcionario y = new Funcionario();

Console.Write("Digite o nome do funcionario: ");
y.nome = Console.ReadLine();

Console.Write("Digite o salario bruto do funcionario: ");
y.SalarioBruto = double.Parse(Console.ReadLine());

Console.Write("Digite o valor total de imposto a pago pelo funcionario: ");
y.imposto = double.Parse(Console.ReadLine());

Console.WriteLine($"Dados do Funcionario \n Nome do Funcionario = {y.nome} \n Salario Liquido {y.SalarioLiquido()}");

Console.Write("\nDigite a porcentagem de aumento do salario do funcionario: ");
double porcentagem = double.Parse(Console.ReadLine());
y.AumentarSalario(porcentagem);

Console.WriteLine($"Salario do funcionario aumentado {porcentagem}%");

Console.WriteLine($"Dados do funcionario atualizados \n Nome do funcionario :{y.nome}\n Salario : {y.SalarioBruto}");

ReadKey();