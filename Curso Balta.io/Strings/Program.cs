using System.Text;
using System.Xml.Serialization;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Métodos adicionais
            var texto = new StringBuilder(); // cria as linhas de forma dinâmica
            texto.Append("Este texto ");
            texto.Append("é um teste");
            texto.Append(" Este texto");
            texto.Append(" é um texto");

            Console.WriteLine(texto);


            // Console.WriteLine(texto.ToLower());
            // Console.WriteLine(texto.ToUpper());
            // Console.WriteLine(texto.Insert(5, "AQUI"));
            // Console.WriteLine(texto.Remove(5, 5));
            // Console.WriteLine(texto.Length);

            // Console.WriteLine(texto.Replace("Este", "isto"));

            // var divisao = texto.Split(" ");
            // Console.WriteLine(divisao[0]);
            // Console.WriteLine(divisao[1]);
            // Console.WriteLine(divisao[2]);
            // Console.WriteLine(divisao[3]);

            // var resultado = texto.Substring(5, 5);
            // Console.WriteLine(resultado);

            // Console.WriteLine(texto.Trim());


        }

        static void GuidBalta()
        {
            var id = Guid.NewGuid();

            id = new Guid("7823de93-c834-4051-90d9-bb10b0a55f36");
            Console.WriteLine(id.ToString().Substring(0, 8)); 
        }

        static void Interpolacao()
        {
            var price = 10.2;
            // Concatenação
            var text1 = "O preço do produto é " + price + " apenas na promoção"; 

            // string.Format = formata
            var text2 = string.Format("O preço do produto é {0} apenas na promoção", price); 

            // Interpolação
            var text3 = $"O preço do produto é {price} apenas na promoção";

            Console.WriteLine(text3);
        }

        static void Comparacao()
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.CompareTo("Testando")); // case sensitive
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // case sensitive
            Console.WriteLine(texto.CompareTo(null)); // dá erro
        }

        static void TerminaEComecaCom()
        {
            var texto = "Este texto é um teste";
            
            Console.WriteLine(texto.StartsWith("Este"));
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.StartsWith("texto"));

            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.EndsWith("xpto"));
        }

        static void Igual()
        {
            // Compara qualquer objeto do mesmo tipo
            var texto = "Este texto é um teste";
            var teste = 33;
            teste.Equals(33);
            
            Console.WriteLine(texto.Equals("Este texto é um teste"));
            Console.WriteLine(texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(texto.Equals("este texto é um teste"));
        }

        static void Indices()
        {
            var texto = "Este texto é um teste";

            // Objeto do mesmo tipo
            Console.WriteLine(texto.IndexOf('é'));
            Console.WriteLine(texto.LastIndexOf('s'));
        }
    }
}
