namespace SomarDigitos;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int digit;
        int sum = 0;

        Console.Write("Informe um número: ");
        number = Convert.ToInt32(Console.ReadLine());

        do
        {
            digit = number % 10; // Ultimo dígito
            sum += digit;
            number /= 10;
        } while(number > 0);

        Console.WriteLine($"A soma do número é {sum}");
        Console.ReadKey();
    }
}
