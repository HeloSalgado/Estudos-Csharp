namespace NumerosPerfeitos;

class Program
{
    static void Main(string[] args)
    {   
        int number;
        int sum = 1;

        Console.Write("Informe um número: ");
        number = Convert.ToInt32(Console.ReadLine());

        for (int  i = 2; i <= number / 2; i++)
        {
            if(number % i == 0)
                sum += i;
          
        }

        if(sum == number)
            Console.WriteLine(string.Format("O número {0} é perfeito", number));
        else 
            Console.WriteLine(string.Format("O número {0} não é perfeito", number));
        Console.ReadKey();
    }
}
