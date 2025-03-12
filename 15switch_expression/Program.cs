// // Variavel
string linguagem = "C#";


// switch (linguagem)
// {
//     case "HTML":
//         Console.WriteLine("Linguagem de marcacao");
//         break;
//     case "CSS":
//         Console.WriteLine("Linguagem de estilos");
//         break;
//     case "C#":
//         Console.WriteLine("Linguagem de programacao");
//         break;

//     default:
//         Console.WriteLine("Linguagem de desconhecida");
//         break;
// }


// Expressao switch

string retorno = linguagem switch
{
    "HTML" => "LINGAGEM DE MARCACAO",
    "CSS" => "LINGAGEM DE ESTILOS",
    "C#" => "LINGAGEM DE PROGRAMACAO",
    _ => "LINGUAGEM DESCONHECIDA"

};
Console.WriteLine(retorno);
