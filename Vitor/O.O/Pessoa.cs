using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.O
{
    //Encapsulamento
     public class Pessoa
    {
        public Pessoa()
        {
            
        }


        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string sobrenome { get; set; }

        private int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public void setNome(string nome)
        {
            this.nome = nome; 
        }
        public string getNome()
        {
            return this.nomeCompleto();
        }
        private string nomeCompleto()
        {
            return this.nome + " " + this.sobrenome;
        }

    }
}
