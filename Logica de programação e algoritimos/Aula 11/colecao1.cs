int [] numeros = new int[5];
string [] nomes = {"João", "Maria", "Pedro", "Ana", "Lucas"};

System.Console.WriteLine(nomes [2]);
numeros [0] = 10;
numeros [1] = 10;
System.Console.WriteLine(numeros[1]);
numeros [2] = 0;
numeros [3] = 5;
numeros [4] = 7;
int tamanho = numeros.Length; //tamanho do vetor
System.Console.WriteLine("O tamanho do vetor é: " + tamanho);
numeros.GetType(); //tipo do vetor
