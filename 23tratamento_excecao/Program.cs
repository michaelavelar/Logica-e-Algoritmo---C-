// Tratamento de excecao com try catch e Finally

try
{
    Console.WriteLine("Informe um numero");
    int numero = Convert.ToInt16(Console.ReadLine());
}
catch (Exception error)
{
    Console.WriteLine("Houve uma falha:" + error.Message);
}
finally
{
    Console.WriteLine("Sistema finalizado");
}

