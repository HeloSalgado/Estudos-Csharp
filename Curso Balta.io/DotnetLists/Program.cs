namespace DotnetLists;


class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        var meuArray = new int[5] {1, 2, 3, 4, 5};

        var funcionarios = new Funcionarios[5];
        funcionarios[0] = new Funcionarios() {Id = 3232, Nome = "Heloisa"};

        // foreach (var funcionario in funcionarios)
        // {
        //     Console.WriteLine(funcionario.Id);
        //     Console.WriteLine(funcionario.Nome);
        // }

        // foreach (var numero in meuArray)
        // {
        //     Console.WriteLine(numero);
        // }

        try 
        {
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine(meuArray[i]);
            // }

            Cadastrar("");
        } catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Não encontrei o index na lista");
        } catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Falha ao cadastrar texto");
        } catch (MinhaException ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.QuandoAconteceu);
            Console.WriteLine("Excessão customizada!");
        } catch (Exception ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Ops, algo deu errado!");
        } finally 
        {
            Console.WriteLine("Chegou ao fim!");
        }
    }

    public static void Cadastrar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
        {
            throw new MinhaException(DateTime.Now);
        }
    }

    public class MinhaException : Exception
    {
        public MinhaException(DateTime time)
        {
            QuandoAconteceu = time;
        }
        public DateTime QuandoAconteceu { get; set; }
    }

    
    public struct Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    } 
}

