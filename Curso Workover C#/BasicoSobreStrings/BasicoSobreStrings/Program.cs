namespace BasicoSobreStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            string? sobrenome;
            string nomeCompleto;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            nomeCompleto = nome + " " + sobrenome;

            Console.WriteLine("Olá {0}", nomeCompleto);
            Console.WriteLine("Seu nome tem {0} caracteres", nome.Length);
            Console.WriteLine("Olá {0}", nome.ToUpper());
            Console.WriteLine("Olá {0}", nome.ToLower());
            Console.WriteLine("Olá {0}", nomeCompleto.ToUpper());

            string fragmento = nomeCompleto.Substring(0, 3);
            Console.WriteLine("Fragmento = {0}", fragmento);

            Console.ReadKey();
        }
    }
}
