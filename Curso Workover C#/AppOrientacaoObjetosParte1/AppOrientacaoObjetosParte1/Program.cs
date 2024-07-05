namespace AppOrientacaoObjetosParte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Aluno> listaAlunos = new List<Aluno>();

                listaAlunos.Add(new("Guilherme")
                {
                    Idade = 15,
                    Peso = 79.9,
                    Sexo = "Masculino"
                });

                listaAlunos.Add(new("João")
                {
                    Idade = 18,
                    Peso = 68.9,
                    Sexo = "Masculino"
                });

                listaAlunos.Add(new("Rafaela")
                {
                    Idade = 17,
                    Peso = 53.6,
                    Sexo = "Feminino"
                });

                Console.WriteLine("Quantidade de alunos na lista {0}", listaAlunos.Count);


                List<Disciplina> disciplinas = new List<Disciplina>();

                disciplinas.Add(new("Programção", new Professor("Tiago"))
                {
                    Nota = 8.5
                });

                disciplinas.Add(new("Matemática", new Professor("Wilson"))
                {
                    Nota = 9.5
                });

                disciplinas.Add(new("História", new Professor("Maria"))
                {
                    Nota = 10.0
                });

                double totalNotas = disciplinas.Sum(item => item.Nota);
                int qtdDisciplinas = disciplinas.Count;
                double mediaNotas = totalNotas / qtdDisciplinas;

                Console.WriteLine("Média geral = {0:F2}", mediaNotas);


                /*
                Console.WriteLine("Info do aluno Nro {0} | {1}", Aluno.NumeroAlunos, listaAlunos[0].ToString());

                Console.WriteLine("Info do aluno Nro {0} | {1}", Aluno.NumeroAlunos, listaAlunos[1].ToString());

                Console.WriteLine("Info do aluno Nro {0} | {1}", Aluno.NumeroAlunos, listaAlunos[2].ToString());
                Console.WriteLine("Número de alunos = {0}", Aluno.NumeroAlunos);*/

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops, deu um erro {0}", ex.Message);
            }


        }
    }
}
