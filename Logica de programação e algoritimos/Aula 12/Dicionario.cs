using static System.Console;

//------Declaração de um dicionario------
Dictionary<string, int> pessoas = new Dictionary<string, int>()
{
    {"João", 20},
    {"Maria", 30},
    {"Pedro", 40}
};
//-------Adicionando daos ao dicionario
pessoas.Add("Clodoaldo", 54);
System.Console.WriteLine($"Tamanho = {pessoas.Count()}");
System.Console.WriteLine(pessoas["Clodoaldo"]);
System.Console.WriteLine($"Tamanho = {pessoas.Count()}");
pessoas.Remove("Clodoaldo");
System.Console.WriteLine($"Tamanho = {pessoas.Count()}");