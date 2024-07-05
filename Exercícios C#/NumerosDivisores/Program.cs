namespace NumerosDivisores;

class Program
{
    static void Main(string[] args)
    {
        int initialNumber;
        int finalNumber;

        Console.Write("Informe o número inicial: ");
        initialNumber = int.Parse(Console.ReadLine());

        Console.Write("Informe o número limite: ");
        finalNumber = int.Parse(Console.ReadLine());

        for(int i = initialNumber; i <= finalNumber; i++)
        {
            if (i % 5 == 0 && i % 9 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadKey();
    }
}
