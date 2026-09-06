using Shared;
using System.Runtime.CompilerServices;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{

    var credits = ConsoleExtension.GetInt("Ingrese el numeros de créditos: ");
    var creditsValue = ConsoleExtension.GetDecimal("Valor crédito.................: ");
    var stratum = ConsoleExtension.GetInt("Estrato del estudiante........: ");

    var registrationValue = CalculateRegistrationValue(credits, creditsValue, stratum);
    var subsidy = CalculateSubsidy(stratum);



    Console.WriteLine($"Costo de la matricuala........: {registrationValue,20:C2}");
    Console.WriteLine($"Valor subsidio................: {subsidy,20:C2}");





    {
        answer = ConsoleExtension.GetValidOptions("¿ Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));



} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");

//METODO 1////////////////

decimal CalculateSubsidy(int stratum)
{
    if (stratum == 1)
    {
        return 200000M;
    }


    if (stratum == 2)

        {
            return 100000M;
        }

        return 0;
    }




    //METODO 2////////////////
    decimal CalculateRegistrationValue(int credits, decimal creditsValue, int stratum)
    {
        decimal value;
        if (credits <= 20)
        {
            value = credits * creditsValue;
        }
        else
        {
            value = 20 * creditsValue + ((credits - 20) * creditsValue * 2);
        }

        if (stratum == 1)
        {
            return value * 0.2m;
        }
        if (stratum == 2)
        {
            return value * 0.5m;
        }

        if (stratum == 3)
        {
            return value * 0.7m;
        }

        return value;

    }





