using Shared;
using System.Runtime.CompilerServices;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{

    var n = ConsoleExtension.GetInt("Ingrese número: ");
    var factorial = MyMath.Factorial(n);
  

    Console.WriteLine();
    Console.WriteLine($"{n}! = {factorial,20:N0}");




    {
        answer = ConsoleExtension.GetValidOptions("¿ Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase))) ;



} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");