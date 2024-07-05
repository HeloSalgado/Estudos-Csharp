using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOrientacaoObjetosParte1
{
    public class Aluno : Pessoa
    {
        private static int numeroAlunos = 0;
        public static int NumeroAlunos
        {
            get { return numeroAlunos; }
        }

        public Aluno(string nome) : base(nome)
        {
            numeroAlunos++;
        }

        public void Estudar(string disciplina)
        {
            Console.WriteLine("{0} está estudando {1}", Nome, disciplina);
        }
    }
}
