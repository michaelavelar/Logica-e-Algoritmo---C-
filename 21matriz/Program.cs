// Matriz
string[,] dados = {
{"Michael", "Programador", "32"},
{"Gabriela", "Analista", "29"},
{"Thor", "Cachorro", "2"}
};


// Exibir dados
Console.WriteLine(dados[2, 0]);

foreach (string dado in dados)
{
    Console.WriteLine(dado);
}