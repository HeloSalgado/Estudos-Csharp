
namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria uma estrutura
            var product = new Product(1, "Mouse gamer", 197.23, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500.0, EProductType.Service);

            Console.WriteLine(product.Id);
            Console.WriteLine(product.Title);
            Console.WriteLine(product.Price);
            Console.WriteLine(product.PriceInDolar(4.5));
            Console.WriteLine(product.Type);
            Console.WriteLine("-------------------------");
            Console.WriteLine(manutencaoEletrica.Id);
            Console.WriteLine(manutencaoEletrica.Title);
            Console.WriteLine(manutencaoEletrica.Price);
            Console.WriteLine(manutencaoEletrica.PriceInDolar(4.5));
            Console.WriteLine(manutencaoEletrica.Type);
        }


    }
    struct Product
    {
        // Propriedades
        public int Id;
        public double Price;
        public string Title;
        public EProductType Type;


        public Product(int id, string title, double price, EProductType type)
        {
            Id = id;
            Title = title;
            Price = price;
            Type = type;
        }

        // Métodos
        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}