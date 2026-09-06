using Shared;
using System.Runtime.CompilerServices;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{

    var desks = ConsoleExtension.GetInt("Ingrese el numeros de escritorios: ");
    var valueToPay = CalculateValuer(desks);
    

    Console.WriteLine($"El valor a pagar es..............: {valueToPay:C2}");
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿ Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));



} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));



//METODO
decimal CalculateValuer(int desks)
{
    var valueToDesks = ConsoleExtension.GetDecimal("Ingrese el valor del escritorio.$: ");
    float discount;

    if (desks < 5)
    {
        discount = 0.1f;
    }
    else if (desks < 10)
    {
        discount = 0.2f;
    }
    else
    {
        discount = 0.4f;
    }

    return desks * valueToDesks * (decimal)(1 - discount);
}

Console.WriteLine("Game Over.");