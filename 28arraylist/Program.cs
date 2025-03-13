using System.Collections;

//ArrayList
ArrayList lista = new ArrayList();

//cadastrar dados
lista.Add("Michael");
lista.Add(32);
lista.Add(true);

//listar
foreach (var l in lista)
{
    Console.WriteLine(l);
}
