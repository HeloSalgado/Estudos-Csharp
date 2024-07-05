namespace VerificarIdade;

class Program
{
    static void Main(string[] args)
    {
        int age;

        Console.Write("Informe a sua idade: ");
        age = int.Parse(Console.ReadLine());

        if(age < 18)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Acesso negado!");
        } else 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Acesso permitido!");
        }

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.ReadKey();
    }
}
