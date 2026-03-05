using System;

class Program
{
    static void Main()
    {
        int turistas = 0;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Aplicativo de controle de fluxo carros");
        Console.WriteLine("Parque Nacional os Lençóis Maranhenses\n");

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Bem-vindo ao aplicativo de controle de fluxo de carros!");
        Console.ResetColor();

        while (true)
        {
            Console.Write("Digite o fluxo de carro (entrada/saida)\n ou sair para encerrar a aplicação: ");
            string fluxo = Console.ReadLine().ToLower();

            if (fluxo == "sair")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nSaindo do aplicativo...");
                Console.WriteLine("Aplicativo encerrado.");
                Console.ResetColor();
                break;
            }

            if (fluxo != "entrada" && fluxo != "saida")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: Por favor, digite 'entrada' ou 'saida'.");
                Console.ResetColor();
                continue;
            }

            Console.Write("Digite o número de turistas: ");
            int t = int.Parse(Console.ReadLine());

            if (fluxo == "entrada")
            {
                turistas += t;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Entrada registrada em: " + DateTime.Now);
                Console.ResetColor();

                Console.WriteLine($"Entrada de {t} turistas registrada.");
            }
            else if (fluxo == "saida")
            {
                turistas -= t;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Saída registrada em: " + DateTime.Now);
                Console.ResetColor();

                Console.WriteLine($"Saída de {t} turistas registrada.");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total de turistas no parque: {turistas}\n");
            Console.ResetColor();
        }
    }
}