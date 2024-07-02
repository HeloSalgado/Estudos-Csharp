namespace Conversor_de_Moedas;

public class Converter
{
    public static double ValueInReal { get; private set; }
    public static double ValueInEuro { get; private set; }
    public static double ValueInAmericanDolar { get; private set; }
    public static double ValueInPeso { get; private set; }
    public static double ValueInWon { get; private set; }


    public static double ConvertToReal(ECoin coin, double value)
    {
        switch (coin)
        {
            case ECoin.Euro:
                ValueInReal = value * 6.08; 
                break;
            case ECoin.DolarAmericano:
                ValueInReal = value * 5.67; 
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

        return ValueInReal;
    }

    public static double ConvertToEuro(ECoin coin, double value)
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
                ValueInEuro = value * 0.16;
                break;
            default:
                throw new ArgumentException("Moeda de origem inválida.");
        }

        return ValueInEuro;
    }

    public static double ConvertToPeso(ECoin coin, double value)
    {
        switch (coin)
        {
            case ECoin.Euro:
                ValueInPeso = value * 982.27; 
                break;
            case ECoin.DolarAmericano:
                ValueInPeso = value * 914.26; 
                break;
            case ECoin.Peso_argentino:
                ValueInPeso = value; 
                break;
            case ECoin.Won:
                ValueInPeso = value * 0.66; 
                break;
            case ECoin.Real:
                ValueInPeso = value * 161.57;
                break;
            default:
                throw new ArgumentException("Moeda de origem inválida.");
        }

        return ValueInPeso;
    }

    public static double ConvertToDolar(ECoin coin, double value)
    {
        switch (coin)
        {
            case ECoin.Euro:
                ValueInAmericanDolar = value * 1.07; 
                break;
            case ECoin.DolarAmericano:
                ValueInAmericanDolar = value; 
                break;
            case ECoin.Peso_argentino:
                ValueInAmericanDolar = value * 0.0011; 
                break;
            case ECoin.Won:
                ValueInAmericanDolar = value * 0.00072; 
                break;
            case ECoin.Real:
                ValueInAmericanDolar = value * 0.18;
                break;
            default:
                throw new ArgumentException("Moeda de origem inválida.");
        }

        return ValueInAmericanDolar;
    }

    public static double ConvertToWon(ECoin coin, double value)
    {
        switch (coin)
        {
            case ECoin.Euro:
                ValueInWon = value * 1488.84; 
                break;
            case ECoin.DolarAmericano:
                ValueInWon = value * 1385.99; 
                break;
            case ECoin.Peso_argentino:
                ValueInWon = value * 1.52; 
                break;
            case ECoin.Won:
                ValueInWon = value; 
                break;
            case ECoin.Real:
                ValueInWon = value * 244.63;
                break;
            default:
                throw new ArgumentException("Moeda de origem inválida.");
        }

        return ValueInWon;
    }
}