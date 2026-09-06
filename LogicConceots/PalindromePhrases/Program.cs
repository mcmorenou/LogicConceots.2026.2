using Shared;


var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    //Data input
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.WriteLine("***FRACES PALINDROMAS***");
    var phrase = ConsoleExtension.GetString("Ingrese la palabra o frase ");

    //Do process
    var isPalindrome = IsPalindrome(phrase);


    //Show results
    Console.BackgroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.Yellow;

    Console.BackgroundColor = ConsoleColor.Blue;
    Console.BackgroundColor = ConsoleColor.White;

    do
    { 
    answer = ConsoleExtension.GetValidOptions("¿ Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

bool IsPalindrome(string? phrase)
{
    throw new NotImplementedException();
}

Console.WriteLine("Game Over.");



