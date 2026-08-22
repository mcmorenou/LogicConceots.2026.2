var numberString = string.Empty;

do
{
    Console.Write("Ingrese número entero o la palabra ´salir´ para salir: ");
    numberString = Console.ReadLine();
    if (numberString == "S" )
    {
        continue;

    }
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberString}, es par.");
        }
        else
        {
            Console.WriteLine($"El número {numberString}, es imapar.");
        }

    }
    else
    {
        Console.WriteLine($"El dato ingresado: {numberString}, no es un numero entero.");

    }


} while (numberString!.ToLower() != "salir");
Console.WriteLine("Game Over.");