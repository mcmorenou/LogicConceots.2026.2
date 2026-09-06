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
    Console.WriteLine("***Matrix***");
    Console.WriteLine();
    var m = ConsoleExtension.GetInt("Enter the value of m:");
    var n = ConsoleExtension.GetInt("Enter the value of n:");
    var p = ConsoleExtension.GetInt("Enter the value of p:");
    


    //Do process

    {
        int[,] A = Matrix.CreateA(m, n);
        int[,] B = Matrix.CreateB(n, p);
        int[,] C = Matrix.Multiply(A, B);

        Console.WriteLine("*** A ***");
        Matrix.Show(A);

        Console.WriteLine("*** B ***");
        Matrix.Show(B);

        Console.WriteLine("*** C ***");
        Matrix.Show(C);
        
    }


    



    do
    {
        answer = ConsoleExtension.GetValidOptions("¿ Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));




Console.WriteLine("GOOD DAY.");

