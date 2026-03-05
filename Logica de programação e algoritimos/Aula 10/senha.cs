using static System.Console;
//Declaração de variáveis
const int SENHAFIXA = 2002;
int senha, contagem = 0;
//Entrada de dados
Write("Digite a senha: ");
senha = int.Parse(ReadLine());
//Processamento de dados
while (senha != SENHAFIXA)
{
    if (contagem>=3)
    {
        System.Console.WriteLine("Acesso bloqueado");
        break;
    }
    contagem++;
    WriteLine("Senha incorreta, tente novamente: ");
    senha = int.Parse(ReadLine());
    Beep (800, 500);
}
if (contagem < 3)
{
    WriteLine("Acesso permitido!");
    
}
else
{
    WriteLine("Numero de tenteativas excedido, aguarde 30 segundos!");
}