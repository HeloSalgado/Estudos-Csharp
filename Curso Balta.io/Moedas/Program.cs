using System.Globalization;

namespace Moedas;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        decimal valor = 10536.25m;                

        // G -> valor padrão, C -> padrão da moeda (R$), E04 -> formatação com numero, N -> só o número sem o cifrão, P -> porcentagem, F -> maior precisão
        Console.WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR"))); // Formatação
        Console.WriteLine(Math.Round(valor)); // Tira a casa decimal 
        Console.WriteLine(Math.Ceiling(valor)); // Arredonda pra cima
        Console.WriteLine(Math.Floor(valor)); // Arredonda pra baixo
    }
}
