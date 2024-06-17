using System.Text;

namespace Jogo_da_Forca;

class Program
{
    static void Main(string[] args)
    {
        string[] palavrasForca = {"Abacaxi", "Morango", "Maçã", "Uva", "Banana", "Pera"};    

        FazerForca(palavrasForca);
    }

    static void FazerForca(string[] palavras){
        StringBuilder letrasErradas = new StringBuilder("Letras erradas: ");

        Random aleatorio = new Random();

        int numeroSorteado = aleatorio.Next(0, palavras.Length);
        String palavraSorteada = palavras[numeroSorteado];

        char letraDigitada;
        char[] forca = new char[palavraSorteada.Length];

        for (int i = 0; i < forca.Length; i++){
            forca[i] = '_';
        }
        
        do
        {
            Console.WriteLine("Bem-vindo(a) ao Jogo Da Forca!");
            Console.WriteLine("Dica: é uma fruta ");
            Console.WriteLine(new string(forca));
            Console.WriteLine(letrasErradas);
            Console.Write("Digite uma letra: ");
            letraDigitada = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (palavraSorteada.Contains(letraDigitada)){
                for (int i = 0; i < palavraSorteada.Length; i++)
                {
                    if (palavraSorteada[i].Equals(letraDigitada)){
                        forca[i] = letraDigitada;
                    }
                }
            } else {
                if (!letrasErradas.ToString().Contains(letraDigitada))
                {
                    letrasErradas.Append(letraDigitada + " ");
                }
            }

            if (new string(forca) == palavraSorteada)
            {
                Console.WriteLine("Parabéns! Você acertou a palavra: " + palavraSorteada);
                break;
            }

            Console.Clear();
        } while (true);

        
    }
}
