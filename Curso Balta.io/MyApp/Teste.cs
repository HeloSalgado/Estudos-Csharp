using System;

namespace MyApp
{
    internal class Teste
    {
        public static void MeuApp()
        {
            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);

            arr[0] = "Item 2";
             
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr2[0]);
        }

        public static void Conversao()
        {
            // Conversão implicita
            int inteiro = 100;
            float real = 25.5f;

            //real = inteiro; // 100.0f

            //// Conversao explicita
            //inteiro = (int)real;

            // Parse + Convert
            //inteiro = int.Parse(real.ToString());
            inteiro = Convert.ToInt32(real);

            Console.WriteLine(inteiro);
            Console.WriteLine(Convert.ToBoolean("true"));
        }

        public static void IsMaiorDeIdade()
        {
            Console.WriteLine("Qual seu nome?");
            var nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade?");
            var idade = Convert.ToInt16(Console.ReadLine());

            var isMaiorDeIdade = idade >= 18;

            if (isMaiorDeIdade)
            {
                Console.WriteLine(nome + ", pode ir pra festa!");
            }
            else
            {
                Console.WriteLine(nome + ", vai ficar em casa");
            }
        }

    }

    
}