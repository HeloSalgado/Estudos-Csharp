namespace SomaDeImpares;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;

        for (int i = 1; i <= 500; i++)
        {
            if(i % 2 != 0 && i % 3 == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine($"Soma = {sum}");
        Console.ReadKey();
    }
}
