
namespace VerificarNumeroPrimo;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int divisores = 0;

        Console.Write("Informe o número desejado: ");

        number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++){
            if(number % i == 0){
                divisores++;
            }
        }

        if(divisores == 2){
            Console.WriteLine("É um número primo!!");
        } else {
            Console.WriteLine("Não é um número primo!");
        }

        Console.ReadKey();
    }
}
