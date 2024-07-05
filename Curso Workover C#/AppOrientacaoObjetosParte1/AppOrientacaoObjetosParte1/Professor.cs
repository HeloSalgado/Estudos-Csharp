using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOrientacaoObjetosParte1
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
        }

        public void Lecionar(string disciplina)
        {
            Console.WriteLine("{0} está lecionando {1}", Nome, disciplina);
        }
    }
}
