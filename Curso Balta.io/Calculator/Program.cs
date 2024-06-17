namespace Calculator
{
    class Program 
    {

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-------------");
            Console.WriteLine("Selecione uma opção: ");
            var res = Convert.ToInt32(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Finalizar(); break;
                default: Menu(); break;
            }

            Console.ReadKey();
        }

        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            var v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            var v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            var v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            var v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            var v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            var v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            double resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é: {resultado}");
            Console.ReadKey();
            Menu();
        }
    
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            var v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            var v2 = Convert.ToDouble(Console.ReadLine());

            double resultado = v1 * v2;

            Console.WriteLine("");
            Console.WriteLine($"O resultado da multiplicação é: {resultado}");

            Console.ReadKey();
            Menu();
        }
    
        static void Finalizar()
        {
            Console.WriteLine("Tem certeza que deseja finalizar o programa? (y/n)");
            var res = Console.ReadLine().ToLower();

            switch (res)
            {
                case "y": Environment.Exit(0); break;
                case "n": Menu(); break;
                default: Finalizar(); break;
            }
        }

    }
}
