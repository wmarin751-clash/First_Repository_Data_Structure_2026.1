using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var weight = ConsoleExtension.GetFloat("Peso de a mercancia (kg).............: ");
    var value = ConsoleExtension.GetDecimal("Valor de la mercancia (COP)........: ");

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");
