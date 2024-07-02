namespace Conversor_de_Moedas;

class Program
{
    public static ECoin ChoseCoin {get; private set;}

    static void Main(string[] args)
    {
        menu();
    }

    public static void menu()
    {
        Console.Clear();
        Console.WriteLine("|************ Bem vindo(a) ao conversor de moedas! ************|");
        Console.WriteLine("|                                                              |");
        Console.WriteLine("|             Escolha a moeda que deseja converter             |");
        Console.WriteLine("|                                                              |");
        Console.WriteLine("| Real brasileiro -> Pressione 'R'                             |\n| Peso argentino -> Pressione 'P'                              |\n| Euro -> Pressione 'E'                                        |\n| Dólar americano -> Pressione 'D'                             |\n| Won sul-coreano -> Pressione 'W'                             |");
        Console.WriteLine("|                                                              |");
        Console.Write("| Digite sua opção: ");
        char chosenCurrencyBefore = (char)Console.ReadKey().Key;
        verificarOpcao(chosenCurrencyBefore);

        Console.Write("| Digite o valor: ");
        double valueToConvert = double.Parse(Console.ReadLine());
        Console.WriteLine("|                                                              |");
        Console.WriteLine("|**************************************************************|");
        Console.WriteLine("|           Escolha para qual moeda deseja converter           |");
        Console.WriteLine("|                                                              |");
        Console.WriteLine("| Real brasileiro -> Pressione 'R'                             |\n| Peso argentino -> Pressione 'P'                              |\n| Euro -> Pressione 'E'                                        |\n| Dólar americano -> Pressione 'D'                             |\n| Won sul-coreano -> Pressione 'W'                             |");
        Console.WriteLine("|                                                              |");
        Console.Write("| Digite sua opção: ");
        char chosenCurrency = (char)Console.ReadKey().Key;
        verificarOpcao(chosenCurrency, valueToConvert);
    }

    public static void verificarOpcao(char option)
    {
        switch (char.ToUpper(option))
        {
            case 'P':
                ChoseCoin = ECoin.Peso_argentino;
                Console.WriteLine("\n| Opção escolhida: Peso argentino");
                break;
            case 'E':
                ChoseCoin = ECoin.Euro;
                Console.WriteLine("\n| Opção escolhida: Euro");
                break;
            case 'D':
                ChoseCoin = ECoin.DolarAmericano;
                Console.WriteLine("\n| Opção escolhida: Dólar americano");
                break;
            case 'W':
                ChoseCoin = ECoin.Won;
                Console.WriteLine("\n| Opção escolhida: Won sul-coreano");
                break;
            case 'R':
                ChoseCoin = ECoin.Real;
                Console.WriteLine("\n| Opção escolhida: Real brasileiro");
                break;
            default:
                Console.WriteLine("\n| Opção inválida!");
                Thread.Sleep(3000);
                menu();
                break;
        }
    }

    public static void verificarOpcao(char option, double value)
    {
        double valueConvert;

        switch (char.ToUpper(option))
        {
            case 'P':
                Console.WriteLine("\n| Opção escolhida: Peso argentino");
                valueConvert = Converter.ConvertToPeso(ChoseCoin, value);
                Thread.Sleep(2000);
                Console.WriteLine($"| Valor convertido para Peso Argentino: {valueConvert:F2}");
                break;
            case 'E':
                Console.WriteLine("\n| Opção escolhida: Euro");
                valueConvert = Converter.ConvertToEuro(ChoseCoin, value);
                Thread.Sleep(2000);
                Console.WriteLine($"| Valor convertido para Euro: {valueConvert:F2}");
                break;
            case 'D':
                Console.WriteLine("\n| Opção escolhida: Dólar americano");
                valueConvert = Converter.ConvertToDolar(ChoseCoin, value);
                Thread.Sleep(2000);
                Console.WriteLine($"| Valor convertido para Dólar americano: {valueConvert:F2}");
                break;
            case 'W':
                Console.WriteLine("\n| Opção escolhida: Won sul-coreano");
                valueConvert = Converter.ConvertToWon(ChoseCoin, value);
                Thread.Sleep(2000);
                Console.WriteLine($"| Valor convertido para Won sul-coreano: {valueConvert:F2}");
                break;
            case 'R':
                Console.WriteLine("\n| Opção escolhida: Real");
                valueConvert = Converter.ConvertToReal(ChoseCoin, value);
                Thread.Sleep(2000);
                Console.WriteLine($"| Valor convertido para Real Brasileiro: {valueConvert:F2}");
                break;
            default:
                Console.WriteLine("\n| Opção inválida!");
                Thread.Sleep(3000);
                menu();
                break;
        }

        Console.WriteLine("|______________________________________________________________|");
    }
}
