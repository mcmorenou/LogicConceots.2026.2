using Shared;


var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    ////Show results
    Console.BackgroundColor = ConsoleColor.Gray;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Clear();



    //Data input
    Console.WriteLine("***RHOMBUS***");
    var size  = ConsoleExtension.GetInt("Enter the size of the rhombus:");



    //Do process
    for ( int i = 0; i < size; i++ )
    {
        int spaces = Math.Abs(size / 2 - i);
        int width = size - (spaces * 2);

        Console.Write(new string(' ', spaces));

        if (width == 1)

        {
            Console.WriteLine("#");
        }
        else
        {
            Console.Write("#");
            Console.Write(new string(' ', width - 2));
            Console.WriteLine("#");
        }

    }



    do
    {
        answer = ConsoleExtension.GetValidOptions("¿ Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));


Console.WriteLine("GOOD DAY.");


