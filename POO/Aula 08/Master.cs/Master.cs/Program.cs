using Master;
using Master.cs;
/*
Console.WriteLine(Tipo.ContaNormal);
Console.WriteLine(Tipo.ContaPoupanca);
Console.WriteLine(Tipo.ContaPJ);
*/

Conta conta = new Conta(12345, 11500.56, new Pessoa("Clodoaldo", 1234546488));

var a = conta.ToString();
Console.WriteLine(a);

ContaPJ pj = new ContaPJ(54321, 50000, new Pessoa("César", 64856343), 20000);

var b = pj.ToString();
Console.WriteLine(b);

ContaPoupanca pp = new ContaPoupanca(666666, 666.66, new Pessoa("Lu", 66666666666), 5.0);

pp.Consulta();

Console.ReadKey();