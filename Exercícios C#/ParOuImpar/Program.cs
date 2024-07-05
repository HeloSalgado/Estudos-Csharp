namespace ParOuImpar;

class Program
{
    static void Main(string[] args)
    {
        int number;

        Console.Write("Informe um número: ");
        number = int.Parse(Console.ReadLine());

        if(number % 2 == 0){
            Console.WriteLine("O número {0} é par", number);
        } else {
            Console.WriteLine("O número {0} é ímpar", number);
        }

        Console.ReadKey();
    }
}
