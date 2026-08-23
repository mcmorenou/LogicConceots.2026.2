using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Ingrese 2 números enteros diferentes");
    var a = ConsoleExtension.GetInt("Ingrese primer número : ");
    var b = ConsoleExtension.GetInt("Ingrese segundo número: ");

    if (a % b == 0 )
    {
        Console.WriteLine($" {b} es multiplo de {a}");

    }

    else if ( b % a == 0)
    {
        Console.WriteLine($" {a} es multiplo de {b}");

    }


        else
        {
            Console.WriteLine($" los números  {a} y  {b} no son multiplos");

        }


    do
    {
        answer = ConsoleExtension.GetValidOptions("¿ Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));



} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");