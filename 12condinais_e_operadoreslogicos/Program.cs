// Variaveis
double valor = 500;
string pagamento = "a prazo";


// condicional
if (valor >= 100 && pagamento == "a vista")
{
    Console.WriteLine($"Desconto de 10%! Total a pagar R${valor * 0.9}");
}
else
{
    Console.WriteLine($"Total a pagar R${valor}");

}