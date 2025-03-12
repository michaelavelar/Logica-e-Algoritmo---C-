// constantes

const string nome = "Michael";
const string sobrenome = "Avelar";
const int idade = 32;
const string cidade = "São Paulo";

// concatenacao através do +

Console.WriteLine("Nome: " + nome + ", Sobrenome: " + sobrenome + ", Idade: " + idade + ", Cidade: " + cidade);

// concatenacao atraves de interpolacao de strings

Console.WriteLine($"{nome} mora em {cidade}.");