namespace StopWatch
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
            Console.WriteLine("S = segundo => 10s = 10 segundos");
            Console.WriteLine("M = minuto => 1m = 1 minuto");
            Console.WriteLine("0 = sair");

            Console.WriteLine("------------------");

            Console.WriteLine("Quanto tempo deseja contar?");
            var data = Console.ReadLine().ToLower();
            var type = char.Parse(data.Substring(data.Length - 1, 1)); //(a partir de quantos caracteres, qtd de caracteres)
            var time = int.Parse(data.Substring(0, data.Length - 1));

            
            if (time == 0)
            {
                Environment.Exit(0);
            }

            Console.WriteLine("------------------");

            Console.WriteLine("Qual função deseja utilizar?");
            Console.WriteLine("1 - Timer");
            Console.WriteLine("2 - Contador");
            var escolha = int.Parse(Console.ReadLine());

            
            var multiplier = 1;

            if (type.Equals('m'))
            {
                multiplier = 60;
            }

            PreStart(time * multiplier, escolha);
        }

        static void PreStart(int time, int escolha)
        {

            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);

            Console.WriteLine("Set...");
            Thread.Sleep(1000);

            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            switch (escolha)
            {
                case 1: Timer(time); break;
                case 2: Contador(time); break;
                default: Menu(); break;
            }

        }
        static void Contador(int time)
        {
            var currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado");
            Thread.Sleep(2000);
            Menu();
        }

        static void Timer(int time)
        {
            for (var i = time; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado");
            Thread.Sleep(2000);
            Menu();
        }
    }
}
