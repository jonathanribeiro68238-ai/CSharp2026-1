using static System.Console;
int anos, meses, dias;
System.Console.WriteLine("Digite a sua idade em dias:");
dias = int.Parse(ReadLine());

anos = dias/365;
meses = anos / 30 ;
dias = (dias%365) % 30;

System.Console.WriteLine($"Anos: {anos}");
System.Console.WriteLine($"Dias : {dias}");
System.Console.WriteLine($"Meses : {meses}");