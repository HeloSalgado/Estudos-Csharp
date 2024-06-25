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
        Console.WriteLine("| Real -> Pressione 'R'                                        |\n| Peso argentino -> Pressione 'P'                              |\n| Euro -> Pressione 'E'                                        |\n| Dólar americano -> Pressione 'D'                             |\n| Won sul-corean -> Pressione 'W'                              |");
        Console.WriteLine("|                                                              |");
        Console.Write("| Digite sua opção: ");
        char chosenCurrencyBefore = (char)Console.ReadKey().Key;
        verificarOpcao(chosenCurrencyBefore);

        Console.Write("| Digite o valor: ");
        double valueToConvert = double.Parse(Console.ReadLine());

        Console.WriteLine("|                                                              |");
        Console.WriteLine("|           Escolha para qual moeda deseja converter           |");
        Console.WriteLine("|                                                              |");
        Console.WriteLine("| Real -> Pressione 'R'                                        |\n| Peso argentino -> Pressione 'P'                              |\n| Euro -> Pressione 'E'                                        |\n| Dólar americano -> Pressione 'D'                             |\n| Won sul-corean -> Pressione 'W'                              |");
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
                Console.WriteLine("\n| Opção escolhida: Real");
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
        ;

        switch (char.ToUpper(option))
        {
            case 'P':
                Console.WriteLine("\n| Opção escolhida: Peso argentino");
                break;
            case 'E':
                Console.WriteLine("\n| Opção escolhida: Euro");
                Converter.ConvertToEuro(ChoseCoin, value);
                break;
            case 'D':
                Console.WriteLine("\n| Opção escolhida: Dólar americano");
                break;
            case 'W':
                Console.WriteLine("\n| Opção escolhida: Won sul-coreano");
                break;
            case 'R':
                Console.WriteLine("\n| Opção escolhida: Real");
                Converter.ConvertToReal(ChoseCoin, value);
                break;
            default:
                Console.WriteLine("\n| Opção inválida!");
                Thread.Sleep(3000);
                menu();
                break;
        }
    }
}
