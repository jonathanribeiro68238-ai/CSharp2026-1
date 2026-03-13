using static System.Console;
//Declaração de uma matriz 3x3
int[,] matriz = new int[3,3];

//Entrada de dados, inserir valores na matriz
System.Console.WriteLine("Matriz Preenchida: ");
for (int i =0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        System.Console.WriteLine($"Digite o valor p/ a posição [{i},{j}]: ");
        matriz[i , j] = int.Parse(ReadLine());
    }
}
System.Console.WriteLine("Matriz Preenchida: ");
for (int i =0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        System.Console.Write(matriz[i, j] + "\t");
    }
    System.Console.WriteLine();
}
