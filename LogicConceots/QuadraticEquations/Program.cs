using Microsoft.VisualBasic;
using Shared;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var a = ConsoleExtension.GetDouble("Ingrese valor a: ");
    var b = ConsoleExtension.GetDouble("Ingrese valor b: ");
    var c = ConsoleExtension.GetDouble("Ingrese valor c: ");
    var solution = QuadraticEquation(a, b, c);
    Console.WriteLine($"x1 = {solution.X1:N5}");
    Console.WriteLine($"X2 = {solution.X2:N5}");

    
    {
        answer = ConsoleExtension.GetValidOptions("¿ Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");

QuadraticEquationSolution QuadraticEquation(double a, double b, double c)
{
    return new QuadraticEquationSolution
    {
        X1 = (-b + Math.Sqrt(b * b - 4 * a * c))/ (2 * a),
        X2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a)
    };
}

public class QuadraticEquationSolution
{
    public double X1 { get; set; }

    public double X2 { get; set; }

}

