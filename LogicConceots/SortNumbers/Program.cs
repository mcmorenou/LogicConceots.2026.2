using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Ingrese 3 números enteros diferentes");
    var a = ConsoleExtension.GetInt("Ingrese primer número : ");
    var b = ConsoleExtension.GetInt("Ingrese segundo número: ");
    var c = ConsoleExtension.GetInt("Ingrese tercer número : ");

   if (a == b || a == c || b == c)
    {
        Console.WriteLine("Los número deben ser diferentes , vuelva a empezar");
        
    }

    else if (a > b  && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($"  {a} > {b} > {c} ");

        }
        else
        {
            Console.WriteLine($"  {a} > {c} > {b} ");

        }

    }
    else if (b > a && b > c)
    {
        if (a > c )
        {
            Console.WriteLine($"  {b} > {a} > {c} ");

        }
        else
        {
            Console.WriteLine($"  {b} > {c} > {a} ");

        }

    }
    else 
    {
        if (a > b )
        {
            Console.WriteLine($"  {c} > {a} > {b} ");

        }
        else
        {
            Console.WriteLine($"  {c} > {b} > {a} ");

        }

    

    }


    do
    {
        answer = ConsoleExtension.GetValidOptions("¿ Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));



} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");