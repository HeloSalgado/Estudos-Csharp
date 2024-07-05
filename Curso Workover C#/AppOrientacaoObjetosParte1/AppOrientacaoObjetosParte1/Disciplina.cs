using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOrientacaoObjetosParte1
{
    public class Disciplina
    {
        private string nome;
        private Professor professor;
        private double nota;

        public string Nome
        {
            get { return nome; }
        }

        public Professor Professor
        {
            get { return professor; }
        }

        public double Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public Disciplina(string nome, Professor professor)
        {
            this.nome = nome;
            this.professor = professor;
        }
    }
}
