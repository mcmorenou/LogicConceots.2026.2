using Shared;
using System.Runtime.ExceptionServices;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Cuantos términos quiere: ");
    double a = 0;
    double b = 1;

    if (n == 1)
    {
        Console.Write($"{a:N0}\t ");
    }
    if (n == 2)
    {
        Console.Write($"{a:N0}\t{b:N0} ");
    }
    if (n >= 3)
    {
        Console.Write($"{a:N0}\t{b:N0}\t ");

        for (int i = 2; i < n; i++)
        {
            double c = a + b;
            Console.Write($"{c:N0}\t");
            a = b;
            b = c;
        }   

    }

    Console.WriteLine();

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿ Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase))) ;
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");





