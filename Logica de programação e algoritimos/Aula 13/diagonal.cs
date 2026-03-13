using static System.Console;
int contagem=0;
Write("Digite a ordem da matriz: ");
int n = int.Parse(ReadLine());
if (n > 0 & n < 10) {
    int[,] matriz = new int[n,n];
    
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            WriteLine($"Elemento [{i},{j}]: ");
            matriz[i, j] = int.Parse(ReadLine());
        }
    }
    WriteLine("Diagonal Principal: ");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j)
            {
                Write(matriz[i,j] + "\t");
            }

            if (matriz[i,j] < 0 )
            {
                contagem++;
            }
        }
    }
    WriteLine($"quantidade de numeros negativos: {contagem}");
}