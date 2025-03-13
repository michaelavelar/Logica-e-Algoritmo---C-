// Criando um Dictionary para armazenar os nomes
Dictionary<int, string> nomes = new Dictionary<int, string>();

// Adicionando elementos no Dictionary
nomes.Add(1, "Michael");
nomes.Add(2, "Gabriela");
nomes.Add(3, "Thor");

// Exibir um elemento através da chave:
Console.WriteLine($"O elemento da chave 1 é: {nomes[1]}");

// Exibindo os elementos do Dictionary
Console.WriteLine("Listagem de todos os elementos do Dictionary:");
foreach (var item in nomes)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}

