using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aulas.Aula01
{
    public class POO
    {

    }

    public class Produto
    {
        public string _nome { get; set; }
        public decimal _preco { get; set; }
        private List<string> _categoria { get; set; }

        public List<string> Categorias => _categoria;
        public Produto(string nome)
        {
            this._nome = nome;
        }

        public Produto(string nome,decimal preco)
        {
            this._nome = nome;
            this._preco = preco;
            this._categoria = new List<string>();
        }

        public void addCategoria(string categoria)
        {
            try
            {
                _categoria.Add(categoria);
                Console.WriteLine("Cadastrado com sucesso");
            }
            catch (Exception ex) { 
            
                Console.WriteLine(ex.Message);
            
            }
            
        }

        public virtual void Funcionalidade()
        {

            Console.WriteLine("Produto em geral");

        }
    }

    public class Carrinho : Produto
    {
        public string _cor { get; set; }
        public string _rodas { get; set; }

        public Carrinho(string troco, decimal preco, string cor, string _rodas) :base(troco,preco)
        {
            this._cor = cor;
            this._rodas = _rodas;
        }

        public override void Funcionalidade()
        {

            Console.WriteLine("Carrinho buzinaço");

        }

    }

}
