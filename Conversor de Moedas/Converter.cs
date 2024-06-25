namespace Conversor_de_Moedas;

public class Converter
{
    public static double ValueInReal { get; private set; }
    public static double ValueInEuro { get; private set; }
    public static double ValueInAmericanDolar { get; private set; }
    public static double ValueInPeso { get; private set; }
    public static double ValueInWon { get; private set; }


    public static void ConvertToReal(ECoin coin, double value)
    {
        switch (coin)
        {
            case ECoin.Euro:
                ValueInReal = value * 5.83; 
                break;
            case ECoin.DolarAmericano:
                ValueInReal = value * 5.45; 
                break;
            case ECoin.Peso_argentino:
                ValueInReal = value * 0.0060; 
                break;
            case ECoin.Won:
                ValueInReal = value * 0.0039; 
                break;
            case ECoin.Real:
                ValueInReal = value;
                break;
            default:
                throw new ArgumentException("Moeda de origem inválida.");
        }
    }

    public static void ConvertToEuro(ECoin coin, double value)
    {
        switch (coin)
        {
            case ECoin.Euro:
                ValueInEuro = value; 
                break;
            case ECoin.DolarAmericano:
                ValueInEuro = value * 0.93; 
                break;
            case ECoin.Peso_argentino:
                ValueInEuro = value * 0.0010; 
                break;
            case ECoin.Won:
                ValueInEuro = value * 0.00067; 
                break;
            case ECoin.Real:
                ValueInEuro = value * 0.17;
                break;
            default:
                throw new ArgumentException("Moeda de origem inválida.");
        }
    }
}