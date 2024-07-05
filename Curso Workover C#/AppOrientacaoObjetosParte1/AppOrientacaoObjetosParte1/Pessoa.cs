using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOrientacaoObjetosParte1
{
    public abstract class Pessoa
    {
        private string nome;
        private int idade;
        private double peso;
        private string sexo;
        public string Nome { get => nome; }
        public int Idade { get => idade; set => idade = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Sexo { get { return sexo; } set => sexo = value; }

        public Pessoa(string nome) 
        { 
            this.nome = nome;
        }

        public void Andar()
        {
            Console.WriteLine("{0} está andando", Nome);
        }

        public void Comer(string comida)
        {
            Console.WriteLine("{0} está comendo {1}", Nome, comida);
        }

        public override string ToString()
        {
            return string.Format("Nome: {0}, Idade: {1}, Peso: {2}, Sexo: {3}", nome, idade, peso, sexo);
        }
    }
}
