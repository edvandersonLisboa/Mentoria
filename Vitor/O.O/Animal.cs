using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O.O
{
    //Herança
    public class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public Animal() { }
        public Animal(string N, int I, string s)
        {
            this.Nome = N;
            this.Idade = I;
            this.Sexo = s;

        }

        public void EmitirSom()
        {
            Console.WriteLine("Som do animal");
        }
    }
    class Cachorro : Animal
    {
        public string TipoDeRaça { get; set; }

        
        public Cachorro()
        {
            
        }
        public Cachorro(string nom,string sexo, int idade):base(nom, idade, sexo)
        {

        }
     
        public void Latir()
        {
            Console.WriteLine("Au Au");
        }
    }

    abstract class Ave
    {
        abstract public void fala();
        public void cantar()
        {
            throw new NotImplementedException();
        }
    }

    interface IAve
    {
        void voar();
        void Miado();
    }
    interface IMamifero
    {
        void Amamentar();
    }

    class Papagaio: Ave, IAve,IMamifero
    {
        public Papagaio()
        {
            
        }
        public Papagaio(string nome, int idade, string sobrenome):base(nome, idade, sobrenome)
        {
        }

        public string TipoDePena { get; set; }

        public override void fala()
        {
            throw new NotImplementedException();
        }

        public void Miado()
        {
            Console.WriteLine("Miau");
        }

        public void voar()
        {
            throw new NotImplementedException();
        }

         void IMamifero.Amamentar()
        {
            throw new NotImplementedException();
        }
    }
}
