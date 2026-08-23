using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
   
    var name = ConsoleExtension.GetString         ("Ingrese el nombre...........................: ");
    var worlHours  = ConsoleExtension.GetFloat    ("Ingrese número de horas trabajadas..........: ");
    var hourValue = ConsoleExtension.GetDecimal   ("Ingrese valor hora..........................: ");
    var salaryMinimun = ConsoleExtension.GetDecimal("Ingrese el valor del salario mínimo mensual.: ");

    var salary = (decimal)worlHours * hourValue;

    if (salary < salaryMinimun)
    {
        Console.WriteLine($"Nombre......................................: {name}");
        Console.WriteLine($"Salario.....................................: {salaryMinimun:C2}");
    }
    else 
    {
        Console.WriteLine($"Nombre......................................: {name}");
        Console.WriteLine($"Salario.....................................:{salary:C2}");
    }
   
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿ Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));



} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");