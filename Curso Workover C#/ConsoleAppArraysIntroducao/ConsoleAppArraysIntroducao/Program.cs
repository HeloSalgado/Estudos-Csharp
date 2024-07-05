namespace ConsoleAppArraysIntroducao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] semana = new string[] { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

            //semana[0] = "Domingo";

            // Sem iteração
            Console.WriteLine("O dia da semana é: {0}", semana[2]);


            // Iteração com for - estrutura de repetição
            for (int i = 0; i < semana.Length; i++)
            {
                Console.WriteLine("O dia da semana é: {0}", semana[i]);
            }
            
            // Iteração com foreach
            foreach (var dia in semana)
            {
                Console.WriteLine("O dia da semana é: {0}", dia);
            }

            Console.WriteLine("A posição de quarta é: {0}", Array.IndexOf(semana, "Quarta"));

            Console.ReadKey();

        }
    }
}
